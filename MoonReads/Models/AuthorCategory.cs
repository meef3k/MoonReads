using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoonReads.Models
{
	public class AuthorCategory
	{
		[Key]
		public int Id { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}

