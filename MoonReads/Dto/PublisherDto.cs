namespace MoonReads.Dto
{
	public class PublisherDto
	{
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
    }
}
