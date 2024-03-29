using MoonReads.Dto.Author;

namespace MoonReads.Dto.Bookshelf;

public class BookshelfDetailDto
{
    public int Id { get; set; }
    public string Status { get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }
    public ICollection<AuthorShortDto> Authors { get; set; }
}