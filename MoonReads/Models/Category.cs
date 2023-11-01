using System.ComponentModel.DataAnnotations;

namespace MoonReads.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public ICollection<BookCategory> BookCategories { get; set; }
		public ICollection<AuthorCategory> AuthorCategories { get; set; }
	}
}
