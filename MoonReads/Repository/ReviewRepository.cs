using MoonReads.Data;
using MoonReads.Dto;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly DataContext _context;

        public ReviewRepository(DataContext context)
        {
            _context = context;
        }

        public Review GetReview(int id)
        {
            return _context.Reviews.FirstOrDefault(r => r.Id == id)!;
        }
        
        public ICollection<ReviewDto> GetReviews(int bookId)
        {
            return _context
                .Reviews
                .Where(r => r.Book!.Id == bookId).OrderByDescending(r => r.Id)
                .Select(r => new ReviewDto
                {
                    Id = r.Id,
                    Description = r.Description,
                    Rate = r.ReviewRatings.Count(rr => rr.Rate == true) - r.ReviewRatings.Count(rr => rr.Rate == false)
                })
                .ToList();
        }
        
        public ICollection<Review> GetUserReviews(User user)
        {
            return _context.Reviews.Where(r => r.User == user).OrderByDescending(r => r.Id).ToList();
        }

        public bool CreateReview(Review review)
        {
            _context.Add(review);

            return Save();
        }

        public bool UpdateReview(Review review)
        {
            _context.Update(review);

            return Save();
        }

        public bool DeleteReview(Review review)
        {
            _context.Remove(review);

            return Save();
        }

        public bool ReviewExists(int id)
        {
            return _context.Reviews.Any(r => r.Id == id);
        }
        
        public bool Save()
        {
            _context.DataVersions.FirstOrDefault(d => d.Table == "Review")!.Version++;
            
            var saved = _context.SaveChanges();

            return saved > 0;
        }
    }
}