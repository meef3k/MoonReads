using System.ComponentModel.DataAnnotations;

namespace MoonReads.Dto
{
    public class UserRemoveDto
    {
        [Required]
        public string Password { get; set; }
    }
}