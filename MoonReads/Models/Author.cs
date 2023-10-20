using System;
namespace MoonReads.Models
{
	public class Author
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
		public ICollection<AuthorCategory> AuthorCategories { get; set; }
		public ICollection<BookAuthor> BookAuthors { get; set; }
	}
}
