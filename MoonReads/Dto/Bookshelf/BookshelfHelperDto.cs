namespace MoonReads.Dto;

public class BookshelfHelperDto
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public string Status { get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }
    public double Rating { get; set; }
    public int TotalRatings { get; set; }
    public string ReleaseDate { get; set; }
    public ICollection<AuthorShortDto> Authors { get; set; }
}