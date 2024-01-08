namespace MoonReads.Dto;

public class BookUserDetailDto
{
    public BookshelfShortDto? Bookshelf { get; set; }
    public RatingShortDto? Rating { get; set; }
    public ICollection<BookReactionsDto>? Reactions { get; set; }
}