using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IReviewRatingRepository
    {
        ReviewRating GetReviewRating(int id);
        ICollection<ReviewRating> GetReviewRatings(int bookId);
        ICollection<ReviewRating> GetUserReviewRatings(User user);
        bool CreateReviewRating(ReviewRating reviewRating);
        bool UpdateReviewRating(ReviewRating reviewRating);
        bool DeleteReviewRating(ReviewRating reviewRating);
        bool ReviewRatingExists(int id);
        bool Save();
    }
}