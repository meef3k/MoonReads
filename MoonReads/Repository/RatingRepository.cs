using System.Linq.Expressions;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MoonReads.Data;
using MoonReads.Dto;
using MoonReads.Dto.Author;
using MoonReads.Dto.Book;
using MoonReads.Dto.Rating;
using MoonReads.Dto.Review;
using MoonReads.Dto.User;
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
        string? searchTerm,
        Dictionary<string, string>? filterTerms,
        string? sortColumn,
        string? sortOrder,
        int? page,
        int? pageSize,
        string? currentUserId)
    {
        var query = _context.Ratings.AsQueryable();
        
        if (filterTerms!.TryGetValue("reported", out var reportedValue))
        {
            if (bool.TryParse(reportedValue, out var booleanValue))
            {
                query = query
                    .Where(r => r.Review!.Reported == booleanValue);
            }
        }
        
        var ratingsQuery = query
            .Where(r => r.Review != null)
            .Select(r => new RatingDetailDto
            {
                Id = r.Id,
                Rate = r.Rate,
                Book = new BookShortDto
                {
                    Id = r.Book.Id,
                    Title = r.Book.Title,
                    ImageUrl = r.Book.ImageUrl,
                    Authors = r.Book.BookAuthors.Select(a => new AuthorShortDto
                    {
                        Id = a.AuthorId,
                        Name = a.Author.Name
                    }).ToList(),
                },
                User = new UserShortDto
                {
                    Id = r.User.Id,
                    UserName = r.User.UserName!,
                    ImageUrl = r.User.Avatar!
                },
                Review = new ReviewDetailDto
                {
                    Id = r.Review!.Id,
                    Title = r.Review.Title,
                    Description = r.Review.Description,
                    CreationDateTime = r.Review.CreationDateTime,
                    Reactions = r.Review.Reactions.Count(rr => rr.Like == true) - r.Review.Reactions.Count(rr => rr.Like == false),
                    UserReaction = r.Review.Reactions.Any(rr => rr.User!.Id == currentUserId && rr.Like) ? "like" : 
                        r.Review.Reactions.Any(rr => rr.User!.Id == currentUserId && !rr.Like) ? "dislike" : "none"
                }
            });

        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            ratingsQuery = ratingsQuery.Where(r =>
                r.Review!.Title.ToLower().Contains(searchTerm.ToLower()) ||
                r.User.UserName.ToLower().Contains(searchTerm.ToLower()));
        }
        
        if (!filterTerms.IsNullOrEmpty())
        {
            var userId = string.Empty;
            int? bookId = null;

            foreach (var filterTerm in filterTerms)
            {
                switch (filterTerm.Key)
                {
                    case "userId":
                        userId = filterTerm.Value;
                        break;

                    case "bookId":
                        int.TryParse(filterTerm.Value, out var bookParsedId);
                        bookId = bookParsedId;
                        break;
                }
            }

            ratingsQuery = ratingsQuery
                .Where(r =>
                    (string.IsNullOrEmpty(userId) || r.User.Id == userId) &&
                    (bookId == null || r.Book.Id == bookId));
        }

        Expression<Func<RatingDetailDto, object>> keySelector = sortColumn?.ToLower() switch
        {
            "username" => rating => rating.User.UserName,
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

        return PagedList<RatingDetailDto>.Create(ratingsQuery, 1, _context.Reviews.Count());
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
                Rate = r.Rate,
                HasReview = r.ReviewId.HasValue
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
        _context.DataVersions.FirstOrDefault(d => d.Table == "Books")!.Version++;

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