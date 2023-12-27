namespace MoonReads.Dto;

public class BookshelfDetailDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }
    public double Rating { get; set; }
    public ICollection<AuthorShortDto> Authors { get; set; }
}