using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoonReads.Models;

public class Bookshelf
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Status { get; set; }
    public string UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
    public int BookId { get; set; }
    [ForeignKey("BookId")]
    public Book Book { get; set; }
}