using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MoonReads.Dto;
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
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserController(
            IUserRepository userRepository,
            ILogger<UserController> logger,
            IMapper mapper,
            UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            _userRepository = userRepository;
            _logger = logger;
            _mapper = mapper;
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
                var (status, message) = await _userRepository.Register(user, "User");
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
        [HttpPost("logout")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> SignOutUser()
        {
            await _signInManager.SignOutAsync();

            return Ok();
        }
        
        [HttpGet("details/{userId}")]
        [ProducesResponseType(200, Type = typeof(UserInfoDto))]
        [ProducesResponseType(400)]
        public IActionResult GetUserInfo(string userId)
        {
            var userInfo = _userRepository.GetUserInfo(userId);

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
            user.Description = userEdit.Description;
            user.Avatar = userEdit.Avatar;
            
            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return NoContent();
            }

            return BadRequest(InternalStatusCodes.EditError);
        }
        
        [Authorize]
        [HttpPut("details/password")]
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
        [HttpPut("details/email")]
        public async Task<IActionResult> EditUserEmail([FromBody] UserDetailEmailDto userEmail)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            var user = await _userManager.FindByIdAsync(userId);
            
            var passwordSignInResult = await _signInManager.CheckPasswordSignInAsync(user!, userEmail.Password, false);

            if (!passwordSignInResult.Succeeded)
            {
                return BadRequest(InternalStatusCodes.InvalidPassword);
            }
            
            user!.Email = userEmail.NewEmail;
            
            var result = await _userManager.UpdateAsync(user);

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

            return Ok();
        }
    }
}
