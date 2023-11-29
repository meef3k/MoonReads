using MoonReads.Dto;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IReviewRepository
    {
        Review GetReview(int id);
        ICollection<ReviewDto> GetReviews(int bookId);
        ICollection<Review> GetUserReviews(User user);
        bool CreateReview(Review review);
        bool UpdateReview(Review review);
        bool DeleteReview(Review review);
        bool ReviewExists(int id);
        bool Save();
    }
}