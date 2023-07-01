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
			CreateMap<Book, BookDto>();
			CreateMap<Author, AuthorDto>();
			CreateMap<Category, CategoryDto>();
			CreateMap<Publisher, PublisherDto>();
		}
	}
}
