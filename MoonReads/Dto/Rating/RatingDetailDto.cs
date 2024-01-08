namespace MoonReads.Dto;

public class RatingDetailDto
{
    public int Id { get; set; }
    public int Rate { get; set; }
    public BookShortDto Book { get; set; }
    public UserShortDto User { get; set; }
    public ReviewDetailDto? Review { get; set; }
}