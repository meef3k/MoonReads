using System.ComponentModel.DataAnnotations;

namespace MoonReads.Dto
{
    public class UserDetailDto
    {
        [Required]
        public string UserName { get; set; }
        public string Description { get; set; }
        public string Avatar { get; set; }
    }
}