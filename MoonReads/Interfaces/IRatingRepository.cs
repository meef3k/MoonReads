using Microsoft.AspNetCore.JsonPatch;
using MoonReads.Dto;
using MoonReads.Dto.Rating;
using MoonReads.Models;

namespace MoonReads.Interfaces;

public interface IRatingRepository
{
    Rating GetRating(int id);
    Rating GetRatingByUser(int bookId, string userId);
    PagedList<RatingDetailDto> GetRatings(
        string? searchTerm,
        Dictionary<string, string>? filterTerms,
        string? sortColumn,
        string? sortOrder,
        int? page,
        int? pageSize,
        string? currentUserId);
    ICollection<RatingReviewDto> GetUserRatings(string userId);
    RatingShortDto? GetUserRating(int bookId, string userId);
    int CreateRating(Rating rating);
    bool UpdateRating(JsonPatchDocument<Rating> updatedRating, Rating rating);
    bool DeleteRating(Rating rating);
    bool RatingExists(int id);
    bool UserRatingExists(int rateId, string userId);
    bool UserBookRatingExists(int bookId, string userId);
    bool Save();
}