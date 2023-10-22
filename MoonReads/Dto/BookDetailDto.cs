namespace MoonReads.Dto
{
    public class BookDetailDto
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
        public required string ReleaseDate { get; set; }
        public int Pages { get; set; }
        public required string Isbn { get; set; }
        public required string Publisher { get; set; }
        public double Rating { get; set; }
        public required List<string> Authors { get; set; }
        public required List<string> Categories { get; set; }
    }
}

