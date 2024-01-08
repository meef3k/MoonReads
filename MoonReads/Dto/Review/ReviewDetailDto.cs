namespace MoonReads.Dto;

public class ReviewDetailDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreationDateTime { get; set; }
    public int Reactions { get; set; }
    public string UserReaction { get; set; }
}