using System;
namespace MoonReads.Models
{
	public class Rating
	{
		public int Id { get; set; }
		public int Rate { get; set; }
		public Book Book { get; set; }
	}
}
