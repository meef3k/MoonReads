using System.ComponentModel.DataAnnotations;

namespace MoonReads.Models
{
	public class Author
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
		public ICollection<AuthorCategory> AuthorCategories { get; set; }
		public ICollection<BookAuthor> BookAuthors { get; set; }
		public ICollection<Rating> Rating { get; set; }
	}
}
