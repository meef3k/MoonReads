using Microsoft.AspNetCore.JsonPatch;
using MoonReads.Dto;
using MoonReads.Models;

namespace MoonReads.Interfaces;

public interface IRatingRepository
{
    Rating GetRating(int id);
    Rating GetRatingByUser(int bookId, string userId);
    ICollection<RatingDetailDto> GetRatings(int bookId);
    RatingShortDto? GetUserRating(int bookId, string userId);
    bool CreateRating(Rating rating);
    bool UpdateRating(JsonPatchDocument<Rating> updatedRating, Rating rating);
    bool DeleteRating(Rating rating);
    bool RatingExists(int id);
    bool UserRatingExists(int rateId, string userId);
    bool UserBookRatingExists(int bookId, string userId);
    bool Save();
}