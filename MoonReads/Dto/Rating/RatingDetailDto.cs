using MoonReads.Dto.Book;
using MoonReads.Dto.Review;
using MoonReads.Dto.User;

namespace MoonReads.Dto.Rating;

public class RatingDetailDto
{
    public int Id { get; set; }
    public int Rate { get; set; }
    public BookShortDto Book { get; set; }
    public UserShortDto User { get; set; }
    public ReviewDetailDto? Review { get; set; }
}