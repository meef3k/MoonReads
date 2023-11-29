using MoonReads.Data;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository
{
    public class ReviewRatingRepository : IReviewRatingRepository
    {
        private readonly DataContext _context;

        public ReviewRatingRepository(DataContext context)
        {
            _context = context;
        }

        public ReviewRating GetReviewRating(int id)
        {
            return _context.ReviewRatings.FirstOrDefault(r => r.Id == id)!;
        }
        
        public ICollection<ReviewRating> GetReviewRatings(int reviewId)
        {
            return _context.ReviewRatings.Where(r => r.Review!.Id == reviewId).OrderByDescending(r => r.Id).ToList();
        }
        
        public ICollection<ReviewRating> GetUserReviewRatings(User user)
        {
            return _context.ReviewRatings.Where(r => r.User == user).OrderByDescending(r => r.Id).ToList();
        }

        public bool CreateReviewRating(ReviewRating reviewRating)
        {
            _context.Add(reviewRating);

            return Save();
        }

        public bool UpdateReviewRating(ReviewRating reviewRating)
        {
            _context.Update(reviewRating);

            return Save();
        }

        public bool DeleteReviewRating(ReviewRating reviewRating)
        {
            _context.Remove(reviewRating);

            return Save();
        }

        public bool ReviewRatingExists(int id)
        {
            return _context.ReviewRatings.Any(r => r.Id == id);
        }
        
        public bool Save()
        {
            _context.DataVersions.FirstOrDefault(d => d.Table == "ReviewRatings")!.Version++;
            
            var saved = _context.SaveChanges();

            return saved > 0;
        }
    }
}