using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoonReads.Helper;
using MoonReads.Interfaces;

namespace MoonReads.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReviewController : Controller
{
    private readonly IReviewRepository _reviewRepository;

    public ReviewController(IReviewRepository reviewRepository)
    {
        _reviewRepository = reviewRepository;
    }
    
    [Authorize]
    [HttpPut("{reviewId}/report")]
    [ProducesResponseType(200)]
    public IActionResult ReportReview(int reviewId)
    {
        if (!_reviewRepository.ReviewExists(reviewId))
            return NotFound();

        if (!ModelState.IsValid)
            return BadRequest(InternalStatusCodes.InvalidPayload);

        var review = _reviewRepository.GetReview(reviewId);
        review.Reported = true;

        if (!_reviewRepository.UpdateReview(review))
        {
            return StatusCode(500, InternalStatusCodes.EditError);
        }

        return NoContent();
    }
}