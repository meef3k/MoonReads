using System;
namespace MoonReads.Models
{
	public class Publisher
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
		public ICollection<Book> Books { get; set; }
	}
}
