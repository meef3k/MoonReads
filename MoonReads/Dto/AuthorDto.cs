using System.ComponentModel.DataAnnotations;

namespace MoonReads.Dto
{
    public class AuthorDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}