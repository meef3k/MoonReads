using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MoonReads.Dto;
using MoonReads.Dto.Reaction;
using MoonReads.Helper;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReactionController : Controller
{
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;
    private readonly IReviewRepository _reviewRepository;
    private readonly IReactionRepository _reactionRepository;

    public ReactionController(IMapper mapper,
        UserManager<User> userManager,
        IReviewRepository reviewRepository,
        IReactionRepository reactionRepository)
    {
        _mapper = mapper;
        _userManager = userManager;
        _reviewRepository = reviewRepository;
        _reactionRepository = reactionRepository;
    }
    
    [Authorize]
    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> CreateReaction([FromQuery][Required] int reviewId, [FromBody] ReactionDto? reactionCreate)
    {
        if (reactionCreate == null)
            return BadRequest(InternalStatusCodes.InvalidPayload);
            
        if (!_reviewRepository.ReviewExists(reviewId))
            return NotFound(InternalStatusCodes.EntityNotExist);

        var review = _reviewRepository.GetReview(reviewId);
            
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

        var user = await _userManager.FindByIdAsync(userId);
            
        if (_reactionRepository.ReactionExists(reviewId, userId))
            return BadRequest(InternalStatusCodes.EntityExist);

        var reactionMap = _mapper.Map<Reaction>(reactionCreate);

        reactionMap.Review = review;
        reactionMap.User = user;
            
        if (!ModelState.IsValid)
            return BadRequest(InternalStatusCodes.InvalidPayload);
            
        var id = _reactionRepository.CreateReaction(reactionMap);

        return id == 0 ? StatusCode(500, InternalStatusCodes.CreateError) : Created(string.Empty, new { id });
    }
    
    [Authorize]
    [HttpPut]
    [ProducesResponseType(400)]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public IActionResult UpdateReaction([FromQuery][Required] int reviewId, [FromBody] ReactionDto? updatedReaction)
    {
        if (updatedReaction == null)
            return BadRequest(InternalStatusCodes.InvalidPayload);

        if (!_reviewRepository.ReviewExists(reviewId))
            return NotFound(InternalStatusCodes.EntityNotExist);

        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

        if (!ModelState.IsValid)
            return BadRequest(InternalStatusCodes.InvalidPayload);

        var reactionMap = _mapper.Map<Reaction>(updatedReaction);

        if (!_reactionRepository.UpdateReaction(reactionMap, reviewId, userId))
        {
            return StatusCode(500, InternalStatusCodes.EditError);
        }

        return NoContent();
    }
    
    [Authorize]
    [HttpDelete]
    [ProducesResponseType(400)]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public IActionResult DeleteReaction([FromQuery][Required] int reviewId)
    {
        if (!_reviewRepository.ReviewExists(reviewId))
            return NotFound(InternalStatusCodes.EntityNotExist);
            
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            
        if (!_reactionRepository.ReactionExists(reviewId, userId))
            return NotFound(InternalStatusCodes.EntityNotExist);

        if (!ModelState.IsValid)
            return BadRequest(InternalStatusCodes.InvalidPayload);

        if (!_reactionRepository.DeleteReaction(reviewId, userId))
        {
            return BadRequest(InternalStatusCodes.DeleteError);
        }

        return NoContent();
    }
}