using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoonReads.Models
{
	public class Rating
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public int Rate { get; set; }
		public int BookId { get; set; }
		[ForeignKey("BookId")]
		public Book? Book { get; set; }
	}
}
