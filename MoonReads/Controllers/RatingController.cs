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
    public class RatingController : Controller
	{
        private readonly IRatingRepository _ratingRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public RatingController(IRatingRepository ratingRepository,
            IBookRepository bookRepository,
            IMapper mapper,
            UserManager<User> userManager)
        {
            _ratingRepository = ratingRepository;
            _bookRepository = bookRepository;
            _mapper = mapper;
            _userManager = userManager;
        }

        [Authorize]
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreateRating([FromQuery] int bookId, [FromBody] RatingDto? ratingCreate)
        {
            if (ratingCreate == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            var ratingMap = _mapper.Map<Rating>(ratingCreate);
            
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            
            var user = await _userManager.FindByIdAsync(userId);

            var book = _bookRepository.GetBook(bookId);
            
            ratingMap.Book = book;
            ratingMap.User = user;

            if (!_ratingRepository.CreateRating(ratingMap))
            {
                return StatusCode(500, InternalStatusCodes.CreateError);
            }

            return NoContent();
        }
    }
}

