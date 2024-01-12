namespace MoonReads.Dto.User;

public class UserTokenDto
{
    public int StatusCode { get; set; }
    public string StatusMessage { get; set; }
    public string AccessToken { get; set; }
    public int AccessTokenExpiresTimeInHours { get; set; }
    public string RefreshToken { get; set; }
    public int RefreshTokenExpiresTimeInDays { get; set; }
}