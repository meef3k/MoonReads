using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoonReads.Models
{
	public class Book
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Title { get; set; }

		public string Description { get; set; }
		public string ImageUrl { get; set; }
		[Required]
		public DateOnly ReleaseDate { get; set; }

		public int Pages { get; set; }
		[Required, RegularExpression(@"^(?:\d{10}|\d{13})$")]
		public string Isbn { get; set; }
		public bool Pending { get; set; }
		[Required]
		public int PublisherId { get; set; }
		[ForeignKey("PublisherId")]
		public Publisher Publisher { get; set; }
		public ICollection<Rating> Rating { get; set; }
		public ICollection<BookAuthor> BookAuthors { get; set; }
		public ICollection<BookCategory> BookCategories { get; set; }
	}
}
