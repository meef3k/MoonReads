using MoonReads.Dto.Rating;

namespace MoonReads.Dto.User;

public class UserInfoDto
{
    public string Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }
    public string Avatar { get; set; }
    public ICollection<RatingReviewDto> Ratings { get; set; }
}