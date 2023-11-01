using System.ComponentModel.DataAnnotations;

namespace MoonReads.Models
{
	public class Publisher
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public string Description { get; set; }
		[Url]
		public string ImageUrl { get; set; }
		public ICollection<Book> Books { get; set; }
	}
}
