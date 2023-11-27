using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MoonReads.Dto;
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
        private readonly IConfiguration _configuration;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserController(IUserRepository userRepository, ILogger<UserController> logger, IConfiguration configuration, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userRepository = userRepository;
            _logger = logger;
            _configuration = configuration;
            _userManager = userManager;
            _signInManager = signInManager;
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
                    return BadRequest("Invalid payload");
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
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
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
                    return BadRequest("Invalid payload");
                var (status, message) = await _userRepository.Register(user, user.Role);
                if (status == 0)
                    return BadRequest(message);
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
        [HttpPost("signout")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> SignOutUser()
        {
            await _signInManager.SignOutAsync();

            return Ok();
        }
        
        [Authorize]
        [HttpGet("details")]
        [ProducesResponseType(200, Type = typeof(User))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetUserInfo()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            var user = await _userManager.FindByIdAsync(userId);
            
            var userInfo = new
            {
                user!.UserName,
                user.Email,
                user.FirstName,
                user.LastName,
                user.Description,
                user.Avatar
            };

            return Ok(userInfo);
        }
        
        [Authorize]
        [HttpPut("details/edit")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> EditUserInfo([FromBody] UserDetailDto userEdit)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            var user = await _userManager.FindByIdAsync(userId);
            
            user!.UserName = userEdit.UserName;
            user.FirstName = userEdit.FirstName;
            user.LastName = userEdit.LastName;
            user.Description = userEdit.Description;
            user.Avatar = userEdit.Avatar;
            
            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return NoContent();
            }

            return BadRequest();
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
                return BadRequest("Invalid password");
            }
            
            var result = await _userManager.DeleteAsync(user!);

            if (!result.Succeeded) return BadRequest(result.Errors);
            await _signInManager.SignOutAsync();

            return Ok();
        }
    }
}
