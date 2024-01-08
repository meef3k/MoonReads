namespace MoonReads.Dto
{
    public class BookDto
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public int Pages { get; set; }
        public required string Isbn { get; set; }
    }
}
