using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoonReads.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Description { get; set; }
        [ForeignKey("BookId")]
        public Book? Book { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }
        public ICollection<ReviewRating> ReviewRatings { get; set; }
    }
}
