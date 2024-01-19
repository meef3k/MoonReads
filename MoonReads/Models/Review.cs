using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoonReads.Models;

public class Review
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    public DateTime CreationDateTime { get; set; }
    public bool Reported { get; set; }
    public virtual Rating Rating { get; set; }
    public ICollection<Reaction> Reactions { get; set; }
}