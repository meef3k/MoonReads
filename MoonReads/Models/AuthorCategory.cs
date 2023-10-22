namespace MoonReads.Models
{
	public class AuthorCategory
	{
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public Author? Author { get; set; }
        public Category? Category { get; set; }
    }
}

