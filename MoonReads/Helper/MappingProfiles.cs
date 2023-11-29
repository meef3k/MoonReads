using AutoMapper;
using MoonReads.Dto;
using MoonReads.Models;

namespace MoonReads.Helper
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
		{
            CreateMap<Author, AuthorDto>();
            CreateMap<AuthorDto, Author>();
            CreateMap<Author, AuthorShortDto>();
            CreateMap<AuthorShortDto, Author>();
            CreateMap<Book, BookDto>();
			CreateMap<BookDto, Book>();
            CreateMap<Category, CategoryDto>();
			CreateMap<CategoryDto, Category>();
			CreateMap<Publisher, PublisherDto>();
			CreateMap<PublisherDto, Publisher>();
			CreateMap<Rating, RatingDto>();
			CreateMap<RatingDto, Rating>();
			CreateMap<Book, BookDetailDto>();
			CreateMap<BookDetailDto, Book>();
			CreateMap<DataVersion, DataVersionDto>();
			CreateMap<DataVersionDto, DataVersion>();
			CreateMap<ReviewDto, Review>();
			CreateMap<Review, ReviewDto>();
			CreateMap<ReviewRatingDto, ReviewRating>();
			CreateMap<ReviewRating, ReviewRatingDto>();
		}
	}
}
