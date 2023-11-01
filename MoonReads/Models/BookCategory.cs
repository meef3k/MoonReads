using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoonReads.Models
{
	public class BookCategory
	{
		[Key]
		public int Id { get; set; }
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}

