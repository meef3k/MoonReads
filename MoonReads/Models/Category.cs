namespace MoonReads.Models
{
	public class Category
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public required ICollection<BookCategory> BookCategories { get; set; }
		public required ICollection<AuthorCategory> AuthorCategories { get; set; }
	}
}
