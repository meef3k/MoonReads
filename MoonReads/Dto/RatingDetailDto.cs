namespace MoonReads.Dto;

public class RatingDetailDto
{
    public int Id { get; set; }
    public int Rate { get; set; }
    public string UserName { get; set; }
    public string UserId { get; set; }
    public ReviewDetailDto? Review { get; set; }
}