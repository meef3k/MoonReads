namespace MoonReads.Dto.User;

public class UserLoginTokenDto
{
    public string AccessToken { get; set; }
    public int AccessTokenExpiresTimeInHours { get; set; }
    public string RefreshToken { get; set; }
    public int RefreshTokenExpiresTimeInDays { get; set; }
}