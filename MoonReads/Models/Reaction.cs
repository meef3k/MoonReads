using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoonReads.Models;

public class Reaction
{
    [Key]
    public int Id { get; set; }
    [Required]
    public bool Like { get; set; }
    public int ReviewId { get; set; }
    [ForeignKey("ReviewId")]
    public Review? Review { get; set; }
    public string UserId { get; set; }
    [ForeignKey("UserId")]
    public User? User { get; set; }
}