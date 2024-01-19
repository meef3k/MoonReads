namespace MoonReads.Dto.Author;

public class AuthorDetailDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string ImageUrl { get; set; }
    public double Rating { get; set; }
}