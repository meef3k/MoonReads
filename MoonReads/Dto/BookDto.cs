using System;
using MoonReads.Models;

namespace MoonReads.Dto
{
	public class BookDto
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public int Pages { get; set; }
        public int ISBN { get; set; }
        public Publisher Publisher { get; set; }
    }
}
