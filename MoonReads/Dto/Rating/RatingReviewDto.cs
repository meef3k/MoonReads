using MoonReads.Dto.Book;
using MoonReads.Dto.Review;

namespace MoonReads.Dto.Rating;

public class RatingReviewDto
{
    public int Id { get; set; }
    public int Rate { get; set; }
    public ReviewDetailDto? Review { get; set; }
    public BookShortDto? Book { get; set; }
}