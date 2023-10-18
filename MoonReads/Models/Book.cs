using System;
namespace MoonReads.Models
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
		public DateOnly ReleaseDate { get; set; }
		public int Pages { get; set; }
		public int ISBN { get; set; }
		public Publisher Publisher { get; set; }
		public ICollection<Rating> Rating { get; set; }
		public ICollection<BookAuthor> BookAuthors { get; set; }
		public ICollection<BookCategory> BookCategories { get; set; }
	}
}
