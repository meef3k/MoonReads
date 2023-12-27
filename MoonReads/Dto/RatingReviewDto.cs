namespace MoonReads.Dto;

public class RatingReviewDto
{
    public int Id { get; set; }
    public int Rate { get; set; }
    public ReviewDetailDto? Review { get; set; }
}