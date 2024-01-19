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

    public bool UpdateReview(Review review)
    {
        _context.Update(review);

        return Save();
    }
    
    public bool Save()
    {
        _context.DataVersions.FirstOrDefault(d => d.Table == "Reviews")!.Version++;

        var saved = _context.SaveChanges();

        return saved > 0;
    }
}