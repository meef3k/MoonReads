namespace MoonReads.Models
{
	public class Book
	{
		public int Id { get; set; }
		public required string Title { get; set; }
		public required string Description { get; set; }
		public required string ImageUrl { get; set; }
		public required DateOnly ReleaseDate { get; set; }
		public required int Pages { get; set; }
		public required string Isbn { get; set; }
		public required Publisher Publisher { get; set; }
		public required ICollection<Rating> Rating { get; set; }
		public required ICollection<BookAuthor> BookAuthors { get; set; }
		public required ICollection<BookCategory> BookCategories { get; set; }
	}
}
