using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using MoonReads.Dto;
using MoonReads.Dto.Rating;
using MoonReads.Helper;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RatingController : Controller
{
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;
    private readonly IBookRepository _bookRepository;
    private readonly IRatingRepository _ratingRepository;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public RatingController(IMapper mapper,
        UserManager<User> userManager,
        IBookRepository bookRepository,
        IRatingRepository ratingRepository,
        IHttpContextAccessor httpContextAccessor)
    {
        _mapper = mapper;
        _userManager = userManager;
        _bookRepository = bookRepository;
        _ratingRepository = ratingRepository;
        _httpContextAccessor = httpContextAccessor;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(PagedList<RatingDetailDto>))]
    public IActionResult GetRatings(
        string? searchTerm,
        [FromQuery] Dictionary<string, string>? filterTerms,
        string? sortColumn,
        string? sortOrder,
        int? page,
        int? pageSize)
    {
        var currentUserId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
        
        var ratings = _ratingRepository.GetRatings(
            searchTerm,
            filterTerms,
            sortColumn,
            sortOrder,
            page,
            pageSize,
            currentUserId);

        if (!ModelState.IsValid)
            return BadRequest(InternalStatusCodes.InvalidPayload);

        return Ok(ratings);
    }

    [Authorize]
    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> CreateRating([FromQuery][Required] int bookId, [FromBody] RatingDto? ratingCreate)
    {
        if (ratingCreate == null)
            return BadRequest(InternalStatusCodes.InvalidPayload);
            
        if (!_bookRepository.BookExists(bookId))
            return NotFound(InternalStatusCodes.EntityNotExist);

        var book = _bookRepository.GetBook(bookId);
            
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

        var user = await _userManager.FindByIdAsync(userId);

        if (_ratingRepository.UserBookRatingExists(bookId, userId))
            return BadRequest(InternalStatusCodes.EntityExist);

        var ratingMap = _mapper.Map<Rating>(ratingCreate);

        ratingMap.User = user!;
        ratingMap.Book = book;
            
        if (!ModelState.IsValid)
            return BadRequest(InternalStatusCodes.InvalidPayload);
            
        var id = _ratingRepository.CreateRating(ratingMap);

        return id == 0 ? StatusCode(500, InternalStatusCodes.CreateError) : Created(string.Empty, new { id });
    }
        
    [Authorize]
    [HttpPatch("{rateId}")]
    [ProducesResponseType(400)]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public IActionResult UpdateRating(int rateId, [FromBody] JsonPatchDocument<Rating>? updatedRating)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            
        var rating = _ratingRepository.GetRating(rateId);
            
        if (updatedRating == null)
            return BadRequest(InternalStatusCodes.InvalidPayload);
            
        if (!_ratingRepository.RatingExists(rateId))
            return NotFound(InternalStatusCodes.EntityNotExist);
            
        if (rating.UserId != userId)
            return BadRequest(InternalStatusCodes.InvalidUser);

        if (!ModelState.IsValid)
            return BadRequest(InternalStatusCodes.InvalidPayload);

        if (!_ratingRepository.UpdateRating(updatedRating, rating))
        {
            return StatusCode(500, InternalStatusCodes.EditError);
        }

        return NoContent();
    }
        
    [Authorize]
    [HttpDelete("{rateId}")]
    [ProducesResponseType(400)]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> DeleteRating(int rateId)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            
        var user = await _userManager.FindByIdAsync(userId);
            
        var rating = _ratingRepository.GetRating(rateId);
            
        if (!_ratingRepository.RatingExists(rateId))
            return NotFound(InternalStatusCodes.EntityNotExist);
            
        if (await _userManager.IsInRoleAsync(user!, UserRoles.User))
        {
            if (rating.UserId != userId)
                return BadRequest(InternalStatusCodes.InvalidUser);
        }

        if (!ModelState.IsValid)
            return BadRequest(InternalStatusCodes.InvalidPayload);

        if (!_ratingRepository.DeleteRating(rating))
        {
            return BadRequest(InternalStatusCodes.DeleteError);
        }

        return NoContent();
    }
}