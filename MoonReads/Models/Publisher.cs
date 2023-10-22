namespace MoonReads.Models
{
	public class Publisher
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public required string Description { get; set; }
		public required string ImageUrl { get; set; }
		public required ICollection<Book> Books { get; set; }
	}
}
