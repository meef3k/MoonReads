using System.ComponentModel.DataAnnotations;

namespace MoonReads.Dto.User;

public class UserRemoveDto
{
    [Required]
    public string Password { get; set; }
}