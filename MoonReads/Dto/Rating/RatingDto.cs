using MoonReads.Dto.Review;

namespace MoonReads.Dto.Rating;

public class RatingDto
{
    public int Id { get; set; }
    public int Rate { get; set; }
    public ReviewDto? Review { get; set; }
}