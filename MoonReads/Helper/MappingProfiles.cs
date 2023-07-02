using System;
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
            CreateMap<Book, BookDto>();
			CreateMap<BookDto, Book>();
            CreateMap<Category, CategoryDto>();
			CreateMap<CategoryDto, Category>();
			CreateMap<Publisher, PublisherDto>();
			CreateMap<PublisherDto, Publisher>();
		}
	}
}
