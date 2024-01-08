using MoonReads.Models;

namespace MoonReads.Interfaces;

public interface IReviewRepository
{
    Review GetReview(int id);
    bool ReviewExists(int reviewId);
    bool UpdateReview(Review review);
}