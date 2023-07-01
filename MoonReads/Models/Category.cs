using System;
namespace MoonReads.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public ICollection<BookCategory> BookCategories { get; set; }
		public ICollection<AuthorCategory> AuthorCategories { get; set; }
	}
}
