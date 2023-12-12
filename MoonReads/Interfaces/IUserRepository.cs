using System.Security.Claims;
using MoonReads.Dto;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IUserRepository
    {
        public Task<(int, string)> Register(UserRegisterDto user, string role);
        public Task<UserTokenDto> Login(UserLoginDto user);
        public Task<UserTokenDto> GetRefreshToken(UserRefreshTokenDto refreshToken, ClaimsPrincipal userClaims);
        public Task<bool> UserExists(string userName);
        public Task<bool> CreateUser(UserRegisterDto user);
        public Task<bool> AddToRole(User user, string role);
        public Task<bool> RoleExists(string role);
    }
}
