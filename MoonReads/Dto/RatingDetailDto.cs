namespace MoonReads.Dto;

public class RatingDetailDto
{
    public int Id { get; set; }
    public int Rate { get; set; }
    public int RateCount { get; set; }
    public string UserName { get; set; }
    public string UserId { get; set; }
    public string UserAvatar { get; set; }
    public ReviewDetailDto? Review { get; set; }
}