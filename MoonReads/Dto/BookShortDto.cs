namespace MoonReads.Dto;

public class BookShortDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }
    public ICollection<AuthorShortDto> Authors { get; set; }
}