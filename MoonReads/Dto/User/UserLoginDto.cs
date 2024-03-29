using System.ComponentModel.DataAnnotations;

namespace MoonReads.Dto.User;

public class UserLoginDto
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
}