using MoonReads.Models;

namespace MoonReads.Interfaces
{
	public interface IRatingRepository
	{
        double GetRatingsForBook(Book book);
        bool CreateRating(Rating rating);
        bool UpdateRating(Rating rating);
        bool DeleteRating(Rating rating);
        bool Save();
    }
}
