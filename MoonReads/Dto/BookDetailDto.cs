using System;

namespace MoonReads.Dto
{
    public class BookDetailDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ReleaseDate { get; set; }
        public int Pages { get; set; }
        public int ISBN { get; set; }
        public string Publisher { get; set; }
        public double Rating { get; set; }
        public List<string> Authors { get; set; }
        public List<string> Categories { get; set; }
    }
}

