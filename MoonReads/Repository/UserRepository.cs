using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MoonReads.Data;
using MoonReads.Dto;
using MoonReads.Dto.User;
using MoonReads.Helper;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository;

public class UserRepository : IUserRepository
{
    private readonly UserManager<User> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IConfiguration _configuration;
    private readonly DataContext _context;
    private readonly IRatingRepository _ratingRepository;

    public UserRepository(UserManager<User> userManager, RoleManager<IdentityRole> roleManager,
        IConfiguration configuration, DataContext context, IRatingRepository ratingRepository)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _configuration = configuration;
        _context = context;
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
                Ratings = _ratingRepository.GetUserRatings(userId)
            })
            .FirstOrDefault();
    }
        
    public PagedList<UserDto> GetUsers(
        string? searchTerm,
        string? sortColumn,
        string? sortOrder,
        int? page,
        int? pageSize)
    {
        var usersQuery = _context.Users
            .Join(_context.UserRoles, 
                u => u.Id, 
                ur => ur.UserId, 
                (u, ur) => new { u, ur })
            .Join(_context.Roles, 
                ur => ur.ur.RoleId, 
                r => r.Id, 
                (ur, r) => new { ur, r }) 
            .Select(c => new UserDto
            {
                Id = c.ur.u.Id,
                UserName = c.ur.u.UserName!,
                Email = c.ur.u.Email!,
                Role = c.r.Name!
            }).AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            usersQuery = usersQuery.Where(u =>
                u.UserName.ToLower().Contains(searchTerm.ToLower()) ||
                u.Email.ToLower().Contains(searchTerm.ToLower()) ||
                u.Role.ToLower().Contains(searchTerm.ToLower()));
        }

        Expression<Func<UserDto, object>> keySelectorString = sortColumn?.ToLower() switch
        {
            "username" => user => user.UserName,
            "email" => user => user.Email,
            "role" => user => user.Role,
            _ => user => user.Id
        };

        usersQuery = sortOrder?.ToLower() == "desc"
            ? usersQuery.OrderByDescending(keySelectorString)
            : usersQuery.OrderBy(keySelectorString);

        if (page != null && pageSize != null)
        {
            return PagedList<UserDto>.Create(usersQuery, (int)page, (int)pageSize);
        }
            
        return PagedList<UserDto>.Create(usersQuery, 1, _context.Users.Count());
    }

    public async Task<(int, string)> Register(UserRegisterDto user, string role)
    {
        if (await UserExists(user.UserName) || await UserExists(user.Email))
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
            Avatar = Defaults.UserPhoto,
            Description = Defaults.UserDescription
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
    
    public async Task<bool> UpdateUser(JsonPatchDocument<UserPatchDto> updatedUser, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);

        if (user == null)
        {
            return false;
        }
        
        var allowedPaths = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Description",
            "Avatar",
            "UserName",
            "Email"
        };

        if (updatedUser.Operations.Any(op => !allowedPaths.Contains(op.path)))
        {
            return false;
        }
        
        var userPatchDto = new UserPatchDto();
        
        updatedUser.ApplyTo(userPatchDto);

        if (!string.IsNullOrEmpty(userPatchDto.UserName))
        {
            if (await _userManager.Users.AnyAsync(u => u.Id != user.Id && u.UserName == userPatchDto.UserName))
                return false;
            user.UserName = userPatchDto.UserName;
        }

        if (!string.IsNullOrEmpty(userPatchDto.Email))
        {
            if (await _userManager.Users.AnyAsync(u => u.Id != user.Id && u.Email == userPatchDto.Email))
                return false;
            user.Email = userPatchDto.Email;
        }

        if (!string.IsNullOrWhiteSpace(userPatchDto.Description))
        {
            user.Description = userPatchDto.Description;
        }
        
        if (!string.IsNullOrWhiteSpace(userPatchDto.Avatar))
        {
            user.Avatar = userPatchDto.Avatar;
        }
        
        var result = await _userManager.UpdateAsync(user);

        return result.Succeeded;
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