namespace MoonReads.Dto;

public class UserInfoDto
{
    public string Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }
    public string Avatar { get; set; }
    public ICollection<RatingReviewDto> Ratings { get; set; }
    public ICollection<BookshelfDetailDto> Read { get; set; }
    public ICollection<BookshelfDetailDto> Reading { get; set; }
    public ICollection<BookshelfDetailDto> ToRead { get; set; }
}