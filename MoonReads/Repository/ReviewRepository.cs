using MoonReads.Data;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository;

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
    
    public bool ReviewExists(int reviewId)
    {
        return _context.Ratings.Any(r => r.ReviewId == reviewId);
    }
}