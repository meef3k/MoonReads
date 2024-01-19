using MoonReads.Dto.Bookshelf;
using MoonReads.Dto.Rating;

namespace MoonReads.Dto.Book;

public class BookUserDetailDto
{
    public BookshelfShortDto? Bookshelf { get; set; }
    public RatingShortDto? Rating { get; set; }
    public ICollection<BookReactionsDto>? Reactions { get; set; }
}