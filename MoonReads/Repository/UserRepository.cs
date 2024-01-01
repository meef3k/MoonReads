using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MoonReads.Data;
using MoonReads.Dto;
using MoonReads.Helper;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository
{
    public class UserRepository : IUserRepository
    {
        private const string DefaultDescription = "Ten użytkownik nie ma jeszcze opisu";
        private const string DefaultImageUrl = "https://cdn-icons-png.flaticon.com/256/847/847969.png";
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly DataContext _context;
        private readonly IBookshelfRepository _bookshelfRepository;
        private readonly IRatingRepository _ratingRepository;

        public UserRepository(UserManager<User> userManager, RoleManager<IdentityRole> roleManager,
            IConfiguration configuration, DataContext context, IBookshelfRepository bookshelfRepository, IRatingRepository ratingRepository)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _context = context;
            _bookshelfRepository = bookshelfRepository;
            _ratingRepository = ratingRepository;
        }
        
        
        public UserInfoDto? GetUserInfo(string userId)
        {
            return _context
                .Users
                .Where(u => u.Id == userId)
                .Select(u => new UserInfoDto
                {
                    Id = u.Id,
                    UserName = u.UserName!,
                    Email = u.Email!,
                    Description = u.Description!,
                    Avatar = u.Avatar!,
                    Ratings = _ratingRepository.GetUserRatings(userId),
                    Read = _bookshelfRepository.GetBookshelves(userId, Statuses.Read),
                    Reading = _bookshelfRepository.GetBookshelves(userId, Statuses.Reading),
                    ToRead = _bookshelfRepository.GetBookshelves(userId, Statuses.ToRead)
                })
                .FirstOrDefault();
        }
        
        public async Task<List<UserDto>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();

            var usersDto = new List<UserDto>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);

                var userDto = new UserDto
                {
                    Id = user.Id,
                    UserName = user.UserName!,
                    Email = user.Email!,
                    Roles = roles.ToList()
                };

                usersDto.Add(userDto);
            }

            return usersDto;
        }

        public async Task<(int, string)> Register(UserRegisterDto user, string role)
        {
            if (await UserExists(user.UserName))
                return (0, InternalStatusCodes.EntityExist);

            if (await CreateUser(user))
                return (1, InternalStatusCodes.UserCreated);
            
            return (0, InternalStatusCodes.CreateError);
        }

        public async Task<UserTokenDto> Login(UserLoginDto user)
        {
            UserTokenDto userTokenDto = new();
            var userLogin = await _userManager.FindByNameAsync(user.UserName) ?? await _userManager.FindByEmailAsync(user.UserName);
            
            if (userLogin == null)
            {
                userTokenDto.StatusCode = 0;
                userTokenDto.StatusMessage = InternalStatusCodes.InvalidLogin;
                return userTokenDto;
            }

            if (!await _userManager.CheckPasswordAsync(userLogin, user.Password))
            {
                userTokenDto.StatusCode = 0;
                userTokenDto.StatusMessage = InternalStatusCodes.InvalidPassword;
                return userTokenDto;
            }

            var userRoles = await _userManager.GetRolesAsync(userLogin);

            var authClaims = new List<Claim>
            {
                new(ClaimTypes.Name, userLogin.UserName!),
                new(ClaimTypes.NameIdentifier, userLogin.Id),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            authClaims.AddRange(userRoles.Select(userRole => new Claim(ClaimTypes.Role, userRole)));

            var refreshTokenValidityInDays = Convert.ToInt64(_configuration["JWTKey:RefreshTokenExpiryTimeInDays"]);
            
            userTokenDto.AccessToken = GenerateToken(authClaims);
            userTokenDto.RefreshToken = GenerateRefreshToken();
            userTokenDto.StatusCode = 1;
            userTokenDto.StatusMessage = InternalStatusCodes.Success;
            userTokenDto.AccessTokenExpiresTimeInHours = Convert.ToInt32(_configuration["JWTKey:TokenExpiryTimeInHours"]);
            userTokenDto.RefreshTokenExpiresTimeInDays = Convert.ToInt32(_configuration["JWTKey:RefreshTokenExpiryTimeInDays"]);
            
            
            userLogin.RefreshToken = userTokenDto.RefreshToken;
            userLogin.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(refreshTokenValidityInDays);
            await _userManager.UpdateAsync(userLogin);

            return userTokenDto;
        }

        public async Task<UserTokenDto> GetRefreshToken(UserRefreshTokenDto refreshToken, ClaimsPrincipal userClaims)
        {
            UserTokenDto userTokenDto = new();
            var userId = userClaims.FindFirstValue(ClaimTypes.NameIdentifier)!;
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null || user.RefreshToken != refreshToken.RefreshToken ||
                user.RefreshTokenExpiryTime <= DateTime.UtcNow)
            {
                userTokenDto.StatusCode = 0;
                userTokenDto.StatusMessage = InternalStatusCodes.InvalidRefreshToken;
                return userTokenDto;
            }
            
            var userRoles = await _userManager.GetRolesAsync(user);

            var authClaims = new List<Claim>
            {
                new(ClaimTypes.Name, user.UserName!),
                new(ClaimTypes.NameIdentifier, user.Id),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            
            authClaims.AddRange(userRoles.Select(userRole => new Claim(ClaimTypes.Role, userRole)));
            
            var newAccessToken = GenerateToken(authClaims);
            var newRefreshToken = GenerateRefreshToken();

            user.RefreshToken = newRefreshToken;
            await _userManager.UpdateAsync(user);

            userTokenDto.StatusCode = 1;
            userTokenDto.StatusMessage = InternalStatusCodes.Success;
            userTokenDto.AccessToken = newAccessToken;
            userTokenDto.RefreshToken = newRefreshToken;
            userTokenDto.AccessTokenExpiresTimeInHours = Convert.ToInt32(_configuration["JWTKey:TokenExpiryTimeInHours"]);
            userTokenDto.RefreshTokenExpiresTimeInDays = Convert.ToInt32(_configuration["JWTKey:RefreshTokenExpiryTimeInDays"]);

            return userTokenDto;
        }

        public async Task<bool> UserExists(string userName)
        {
            var userExists = await _userManager.FindByNameAsync(userName) ?? await _userManager.FindByEmailAsync(userName);
            return userExists != null;
        }

        public async Task<bool> CreateUser(UserRegisterDto user)
        {
            var createUser = new User
            {
                Email = user.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = user.UserName,
                Avatar = DefaultImageUrl,
                Description = DefaultDescription
            };

            var createUserResult = await _userManager.CreateAsync(createUser, user.Password);
            if (!createUserResult.Succeeded) return false;
            return await AddToRole(createUser, UserRoles.User);
        }

        public async Task<bool> AddToRole(User user, string role)
        {
            if (!await RoleExists(role)) return false;
            var currentRoles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user, currentRoles);
            var addToRole = await _userManager.AddToRoleAsync(user, role);
            return addToRole.Succeeded;
        }

        public async Task<bool> RoleExists(string role)
        {
            return await _roleManager.RoleExistsAsync(role);
        }

        private string GenerateToken(IEnumerable<Claim> claims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWTKey:Secret"]!));
            var tokenExpiryTimeInHours = Convert.ToInt64(_configuration["JWTKey:TokenExpiryTimeInHours"]!);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _configuration["JWTKey:ValidIssuer"],
                Audience = _configuration["JWTKey:ValidAudience"],
                Expires = DateTime.UtcNow.AddHours(tokenExpiryTimeInHours),
                SigningCredentials = new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256),
                Subject = new ClaimsIdentity(claims)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private static string GenerateRefreshToken()
        {
            var randomNumber = new byte[64];
            using var random = RandomNumberGenerator.Create();
            random.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }
    }
}
