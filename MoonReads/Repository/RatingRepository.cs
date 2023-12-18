using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using MoonReads.Data;
using MoonReads.Dto;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository;

public class RatingRepository : IRatingRepository
{
    private readonly DataContext _context;

    public RatingRepository(DataContext context)
    {
        _context = context;
    }

    public Rating GetRating(int id)
    {
        return _context.Ratings.Include(r => r.Review).FirstOrDefault(r => r.Id == id)!;
    }

    public Rating GetRatingByUser(int bookId, string userId)
    {
        return _context.Ratings.Where(r => r.BookId == bookId).FirstOrDefault(r => r.UserId == userId)!;
    }

    public ICollection<RatingDetailDto> GetRatings(int bookId)
    {
        return _context
            .Ratings
            .Where(r => r.BookId == bookId && r.Review != null)
            .Select(r => new RatingDetailDto
            {
                Id = r.Id,
                Rate = r.Rate,
                UserName = r.User.UserName!,
                UserId = r.UserId,
                Review = new ReviewDetailDto
                {
                    Id = r.Review!.Id,
                    Title = r.Review.Title,
                    Description = r.Review.Description,
                    CreationDateTime = r.Review.CreationDateTime,
                    Reactions = r.Review.Reactions.Count(rr => rr.Like == true) - r.Review.Reactions.Count(rr => rr.Like == false)
                }
            })
            .OrderByDescending(r => r.Review!.Reactions)
            .ToList();
    }
    
    public RatingShortDto? GetUserRating(int bookId, string userId)
    {
        return _context
            .Ratings
            .Where(r => r.BookId == bookId && r.UserId == userId)
            .Select(r => new RatingShortDto
            {
                Id = r.Id,
                Rate = r.Rate
            })
            .FirstOrDefault();
    }

    public bool CreateRating(Rating rating)
    {
        if (rating.Review != null)
        {
            rating.Review.CreationDateTime = DateTime.UtcNow;
            _context.Add(rating.Review);
        }
        
        _context.Add(rating);

        return Save();
    }

    public bool UpdateRating(JsonPatchDocument<Rating> updatedRating, Rating rating)
    {
        if (updatedRating.Operations.Any(o => o.path == "/Review"))
        {
            var review = _context.Reviews.Where(r => r.Id == rating.ReviewId);

            
            foreach (var op in updatedRating.Operations.Where(op => op.path.StartsWith("/Review/")))
            {
                var propertyName = op.path.Substring("/Review/".Length);
                var property = typeof(Review).GetProperty(propertyName);
                
                if (property != null)
                {
                    property.SetValue(review, op.value);
                }
            }
        }
        
        updatedRating.ApplyTo(rating);

        return Save();
    }

    public bool DeleteRating(Rating rating)
    {
        if (rating.ReviewId != null)
        {
            DeleteRatingReviewReactions(rating.ReviewId);
            DeleteRatingReview(rating.ReviewId);
        }
        
        _context.Remove(rating);

        return Save();
    }
    
    public bool RatingExists(int id)
    {
        return _context.Ratings.Any(r => r.Id == id);
    }

    public bool UserRatingExists(int rateId, string userId)
    {
        return _context.Ratings.Where(r => r.Id == rateId).Any(r => r.UserId == userId);
    }
    
    public bool UserBookRatingExists(int bookId, string userId)
    {
        return _context.Ratings.Where(r => r.BookId == bookId).Any(r => r.UserId == userId);
    }

    public bool Save()
    {
        _context.DataVersions.FirstOrDefault(d => d.Table == "Ratings")!.Version++;

        var saved = _context.SaveChanges();

        return saved > 0;
    }
    
    private void DeleteRatingReviewReactions(int? reviewId)
    {
        var ratingReviewReactions = _context
            .Reactions
            .Where(r => r.Review!.Id == reviewId)
            .ToList();

        foreach (var ratingReviewReaction in ratingReviewReactions)
        {
            _context.Reactions.Remove(ratingReviewReaction);
        }
    }
    
    private void DeleteRatingReview(int? reviewId)
    {
        var ratingReview = _context
            .Reviews
            .FirstOrDefault(r => r.Id == reviewId);

        _context.Reviews.Remove(ratingReview!);
    }
}