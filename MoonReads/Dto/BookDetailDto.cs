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
        public double Rating { get; set; }
        public int TotalRatings { get; set; }
        public int TotalReviews { get; set; }
        public string Bookshelf { get; set; }
        public PublisherShortDto Publisher { get; set; }
        public required List<AuthorShortDto> Authors { get; set; }
        public required List<CategoryDto> Categories { get; set; }
    }
}

