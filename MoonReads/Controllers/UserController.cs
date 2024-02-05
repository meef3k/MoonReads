using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using MoonReads.Dto.User;
using MoonReads.Helper;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UserController> _logger;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ICacheRepository _cacheRepository;

        public UserController(
            IUserRepository userRepository,
            ILogger<UserController> logger,
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            ICacheRepository cacheRepository)
        {
            _userRepository = userRepository;
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _cacheRepository = cacheRepository;
        }

        [HttpPost]
        [Route("login")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Login(UserLoginDto user)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(InternalStatusCodes.InvalidPayload);
                var result = await _userRepository.Login(user);
                if (result.StatusCode == 0)
                    return BadRequest(result.StatusMessage);
                
                var userToken = new UserLoginTokenDto
                {
                    AccessToken = result.AccessToken,
                    AccessTokenExpiresTimeInHours = result.AccessTokenExpiresTimeInHours,
                    RefreshToken = result.RefreshToken,
                    RefreshTokenExpiresTimeInDays = result.RefreshTokenExpiresTimeInDays
                };
                
                return Ok(userToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException?.Message);
            }
        }

        [HttpPost]
        [Route("register")]
        [ProducesResponseType(200)]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Register(UserRegisterDto user)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(InternalStatusCodes.InvalidPayload);
                var (status, message) = await _userRepository.Register(user, UserRoles.User);
                if (status == 0)
                    return BadRequest(message);
                _cacheRepository.RemoveData(ControllerContext.ActionDescriptor.ControllerName);
                return CreatedAtAction(nameof(Register), user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [Authorize]
        [HttpPost]
        [Route("refresh")]
        [ProducesResponseType(200)]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> RefreshToken(UserRefreshTokenDto refreshToken)
        {
            try
            {
                var result = await _userRepository.GetRefreshToken(refreshToken, User);
                if (result.StatusCode == 0)
                    return BadRequest(result.StatusMessage);

                var userToken = new UserLoginTokenDto
                {
                    AccessToken = result.AccessToken,
                    AccessTokenExpiresTimeInHours = result.AccessTokenExpiresTimeInHours,
                    RefreshToken = result.RefreshToken,
                    RefreshTokenExpiresTimeInDays = result.RefreshTokenExpiresTimeInDays
                };
                
                return Ok(userToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        
        [Authorize]
        [HttpPost("logout")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> SignOutUser()
        {
            await _signInManager.SignOutAsync();

            return Ok();
        }
        
        [HttpGet("{userId}/details")]
        [ProducesResponseType(200, Type = typeof(UserInfoDto))]
        [ProducesResponseType(400)]
        public IActionResult GetUserInfo(string userId)
        {
            var userInfo = _userRepository.GetUserInfo(userId);

            return Ok(userInfo);
        }
        
        [Authorize(Roles = $"{UserRoles.Admin}")]
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(UserDto))]
        [ProducesResponseType(400)]
        public IActionResult GetUsers(
            string? searchTerm,
            string? sortColumn,
            string? sortOrder,
            int? page,
            int? pageSize)
        {
            var path = HttpContext.Request.GetEncodedUrl();
            
            var cacheData = _cacheRepository.GetData<PagedList<UserDto>>(path);

            if (cacheData is { Items.Count: > 0 })
                return Ok(cacheData);
            
            var users = _userRepository.GetUsers(
                searchTerm,
                sortColumn,
                sortOrder,
                page,
                pageSize);
            
            _cacheRepository.SetData(path, users, DateTimeOffset.Now.AddMinutes(Defaults.CacheExpiryTime));

            return Ok(users);
        }
        
        [Authorize(Roles = $"{UserRoles.Admin}")]
        [HttpPut("{userId}/role")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> EditUserRole(string userId, [FromBody] UserRoleDto userRole)
        {
            var user = await _userManager.FindByIdAsync(userId);

            var role = userRole.Role.First().ToString().ToUpper() + userRole.Role[1..].ToLower();

            if (!await _userRepository.RoleExists(role))
                return NotFound(InternalStatusCodes.EntityNotExist);

            if (await _userRepository.AddToRole(user!, role))
            {
                return NoContent();
            }

            return BadRequest(InternalStatusCodes.EditError);
        }
        
        [Authorize]
        [HttpPatch("edit")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateUser([FromBody] JsonPatchDocument<UserPatchDto>? updatedUser)
        {
            if (updatedUser == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);
            
            if (!TryValidateModel(updatedUser))
                return StatusCode(500, InternalStatusCodes.EditError);
            
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            
            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!await _userRepository.UpdateUser(updatedUser, userId))
            {
                return StatusCode(500, InternalStatusCodes.EditError);
            }

            return NoContent();
        }
        
        [Authorize]
        [HttpPut("edit/password")]
        public async Task<IActionResult> EditUserPassword([FromBody] UserDetailPasswordDto userPassword)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            var user = await _userManager.FindByIdAsync(userId);
            
            var passwordSignInResult = await _signInManager.CheckPasswordSignInAsync(user!, userPassword.Password, false);

            if (!passwordSignInResult.Succeeded)
            {
                return BadRequest(InternalStatusCodes.InvalidPassword);
            }

            if (userPassword.NewPassword != userPassword.ConfirmNewPassword)
            {
                return BadRequest(InternalStatusCodes.PasswordsNotEqual);
            }
            
            var token = await _userManager.GeneratePasswordResetTokenAsync(user!);

            var result = await _userManager.ResetPasswordAsync(user!, token, userPassword.NewPassword);

            if (result.Succeeded)
            {
                return NoContent();
            }

            return BadRequest(InternalStatusCodes.EditError);
        }
        
        [Authorize]
        [HttpDelete("remove")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(409)]
        public async Task<IActionResult> RemoveUser([FromBody] UserRemoveDto model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            var user = await _userManager.FindByIdAsync(userId);
            
            var passwordSignInResult = await _signInManager.CheckPasswordSignInAsync(user!, model.Password, false);

            if (!passwordSignInResult.Succeeded)
            {
                return BadRequest(InternalStatusCodes.InvalidPassword);
            }
            
            var result = await _userManager.DeleteAsync(user!);

            if (!result.Succeeded) return BadRequest(InternalStatusCodes.DeleteError);
            await _signInManager.SignOutAsync();
            
            _cacheRepository.RemoveData(ControllerContext.ActionDescriptor.ControllerName);

            return Ok();
        }
    }
}
