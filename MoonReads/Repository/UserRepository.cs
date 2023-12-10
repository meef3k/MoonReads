using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using MoonReads.Dto;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public UserRepository(UserManager<User> userManager, RoleManager<IdentityRole> roleManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        public async Task<(int, string)> Register(UserRegisterDto user, string role)
        {
            if (await UserExists(user.UserName))
                return (0, "User already exists");

            if (await CreateUser(user, role))
                return (1, "User successfully created");
            
            return (0, "Something went wrong while creating");
        }

        public async Task<UserTokenDto> Login(UserLoginDto user)
        {
            UserTokenDto userTokenDto = new();
            var userLogin = await _userManager.FindByNameAsync(user.UserName);
            
            if (userLogin == null)
            {
                userTokenDto.StatusCode = 0;
                userTokenDto.StatusMessage = "Invalid username";
                return userTokenDto;
            }

            if (!await _userManager.CheckPasswordAsync(userLogin, user.Password))
            {
                userTokenDto.StatusCode = 0;
                userTokenDto.StatusMessage = "Invalid password";
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
            userTokenDto.StatusMessage = "Success";
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
                userTokenDto.StatusMessage = "Invalid access token or refresh token";
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
            userTokenDto.StatusMessage = "Success";
            userTokenDto.AccessToken = newAccessToken;
            userTokenDto.RefreshToken = newRefreshToken;
            userTokenDto.AccessTokenExpiresTimeInHours = Convert.ToInt32(_configuration["JWTKey:TokenExpiryTimeInHours"]);
            userTokenDto.RefreshTokenExpiresTimeInDays = Convert.ToInt32(_configuration["JWTKey:RefreshTokenExpiryTimeInDays"]);

            return userTokenDto;
        }

        public async Task<bool> UserExists(string userName)
        {
            var userExists = await _userManager.FindByNameAsync(userName);
            return userExists != null;
        }

        public async Task<bool> CreateUser(UserRegisterDto user, string role)
        {
            var createUser = new User
            {
                Email = user.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName
            };

            var createUserResult = await _userManager.CreateAsync(createUser, user.Password);
            if (!createUserResult.Succeeded) return false;
            return await AddToRole(createUser, role);
        }

        public async Task<bool> AddToRole(User user, string role)
        {
            if (!await RoleExists(role)) return false;
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
