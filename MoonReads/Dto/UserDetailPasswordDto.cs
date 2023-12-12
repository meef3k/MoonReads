using System.ComponentModel.DataAnnotations;

namespace MoonReads.Dto
{
    public class UserDetailPasswordDto
    {
        [Required]
        public string Password { get; set; }
        [Required]
        public string NewPassword { get; set; }
        [Required]
        public string ConfirmNewPassword { get; set; }
    }
}