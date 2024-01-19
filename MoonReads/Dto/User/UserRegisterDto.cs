using System.ComponentModel.DataAnnotations;

namespace MoonReads.Dto.User;

public class UserRegisterDto
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
    [EmailAddress]
    [Required]
    public string Email { get; set; }
}