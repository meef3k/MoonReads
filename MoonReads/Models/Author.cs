namespace MoonReads.Models
{
	public class Author
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public required string Description { get; set; }
		public required string ImageUrl { get; set; }
		public required ICollection<AuthorCategory> AuthorCategories { get; set; }
		public required ICollection<BookAuthor> BookAuthors { get; set; }
	}
}
