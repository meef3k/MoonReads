using System.Linq.Expressions;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using MoonReads.Data;
using MoonReads.Dto;
using MoonReads.Interfaces;
using MoonReads.Models;
using Newtonsoft.Json;

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

    public PagedList<RatingDetailDto> GetRatings(
        int bookId,
        string? searchTerm,
        string? sortColumn,
        string? sortOrder,
        int? page,
        int? pageSize)
    {
        var ratingsQuery = _context.Ratings
            .Where(r => r.BookId == bookId && r.Review != null)
            .Select(r => new RatingDetailDto
            {
                Id = r.Id,
                Rate = r.Rate,
                UserName = r.User.UserName!,
                UserId = r.UserId,
                UserAvatar = r.User.Avatar!,
                Review = new ReviewDetailDto
                {
                    Id = r.Review!.Id,
                    Title = r.Review.Title,
                    Description = r.Review.Description,
                    CreationDateTime = r.Review.CreationDateTime,
                    Reactions = r.Review.Reactions.Count(rr => rr.Like == true) - r.Review.Reactions.Count(rr => rr.Like == false)
                }
            }).AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            ratingsQuery = ratingsQuery.Where(p =>
                p.Review!.Title.ToLower().Contains(searchTerm.ToLower()) ||
                p.UserName.ToLower().Contains(searchTerm.ToLower()));
        }

        Expression<Func<RatingDetailDto, object>> keySelector = sortColumn?.ToLower() switch
        {
            "username" => rating => rating.UserName,
            "rate" => rating => rating.Rate,
            "title" => rating => rating.Review!.Title,
            "creationdatetime" => rating => rating.Review!.CreationDateTime,
            "reactions" => rating => rating.Review!.Reactions,
            _ => rating => rating.Id
        };

        ratingsQuery = sortOrder?.ToLower() == "desc" ? ratingsQuery.OrderByDescending(keySelector) : ratingsQuery.OrderBy(keySelector);

        if (page != null && pageSize != null)
        {
            return PagedList<RatingDetailDto>.Create(ratingsQuery, (int)page, (int)pageSize);
        }
            
        return PagedList<RatingDetailDto>.Create(ratingsQuery, 1, _context.Ratings.Count());
    }

    public ICollection<RatingReviewDto> GetUserRatings(string userId)
    {
        return _context
            .Ratings
            .Where(r => r.UserId == userId && r.Review != null)
            .Select(r => new RatingReviewDto
            {
                Id = r.Id,
                Rate = r.Rate,
                Review = new ReviewDetailDto
                {
                    Id = r.Review!.Id,
                    Title = r.Review.Title,
                    Description = r.Review.Description,
                    CreationDateTime = r.Review.CreationDateTime,
                    Reactions = r.Review.Reactions.Count(rr => rr.Like == true) - r.Review.Reactions.Count(rr => rr.Like == false)
                },
                Book = new BookShortDto
                {
                    Id = r.BookId,
                    Title = r.Book.Title,
                    ImageUrl = r.Book.ImageUrl,
                    Authors = r.Book.BookAuthors.Select(a => new AuthorShortDto
                    {
                        Id = a.AuthorId,
                        Name = a.Author.Name
                    }).ToList(),
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

    public int CreateRating(Rating rating)
    {
        if (rating.Review != null)
        {
            rating.Review.CreationDateTime = DateTime.UtcNow;
            _context.Add(rating.Review);
        }
        
        _context.Add(rating);

        return Save() ? rating.Id : 0;
    }

    public bool UpdateRating(JsonPatchDocument<Rating> updatedRating, Rating rating)
    {
        var reviewPath = updatedRating.Operations.FirstOrDefault(op => op.path.Equals("Review", StringComparison.OrdinalIgnoreCase));
        var ratePath = updatedRating.Operations.FirstOrDefault(op => op.path.Equals("Rate", StringComparison.OrdinalIgnoreCase));

        if (reviewPath != null)
        {
            if (rating.Review == null)
            {
                updatedRating.ApplyTo(rating);
                rating.Review!.CreationDateTime = DateTime.UtcNow;
            }
            else
            {
                var reviewPatch = reviewPath.value.ToString();
                JsonConvert.PopulateObject(reviewPatch!, rating.Review);
            }
        }
        
        if (ratePath != null)
        {
            var rateValue = (int)(long)ratePath.value;
            rating.Rate = rateValue;
        }
        
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