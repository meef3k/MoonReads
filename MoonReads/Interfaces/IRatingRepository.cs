using MoonReads.Models;

namespace MoonReads.Interfaces
{
	public interface IRatingRepository
	{
        double GetRatingsForBook(Book book);
        bool CreateRating(Rating rating);
        bool Save();
	}
}
