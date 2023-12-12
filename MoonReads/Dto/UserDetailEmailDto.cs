using System.ComponentModel.DataAnnotations;

namespace MoonReads.Dto
{
    public class UserDetailEmailDto
    {
        [EmailAddress]
        [Required]
        public string NewEmail { get; set; }
        [Required]
        public string Password { get; set; }
    }
}