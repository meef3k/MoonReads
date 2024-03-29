﻿using AutoMapper;
using Azure;
using Microsoft.AspNetCore.JsonPatch;
using MoonReads.Dto;
using MoonReads.Dto.Author;
using MoonReads.Dto.Book;
using MoonReads.Dto.Bookshelf;
using MoonReads.Dto.Category;
using MoonReads.Dto.DataVersion;
using MoonReads.Dto.Publisher;
using MoonReads.Dto.Rating;
using MoonReads.Dto.Reaction;
using MoonReads.Dto.Review;
using MoonReads.Dto.User;
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
			CreateMap<Book, BookDetailDto>();
			CreateMap<BookDetailDto, Book>();
			CreateMap<DataVersion, DataVersionDto>();
			CreateMap<DataVersionDto, DataVersion>();
			CreateMap<AuthorCategoryDto, AuthorCategory>();
			CreateMap<AuthorCategory, AuthorCategoryDto>();
			CreateMap<BookAuthorDto, BookAuthor>();
			CreateMap<BookAuthor, BookAuthorDto>();
			CreateMap<BookCategoryDto, BookCategory>();
			CreateMap<BookCategory, BookCategoryDto>();
			CreateMap<AuthorDetailDto, Author>();
			CreateMap<Author, AuthorDetailDto>();
			CreateMap<RatingDto, Rating>();
			CreateMap<Rating, RatingDto>();
			CreateMap<RatingDetailDto, Rating>();
			CreateMap<Rating, RatingDetailDto>();
			CreateMap<ReviewDto, Review>();
			CreateMap<Review, ReviewDto>();
			CreateMap<ReviewDetailDto, Review>();
			CreateMap<Review, ReviewDetailDto>();
			CreateMap<ReactionDto, Reaction>();
			CreateMap<Reaction, ReactionDto>();
			CreateMap<RatingShortDto, Rating>();
			CreateMap<Rating, RatingShortDto>();
			CreateMap<BookshelfDto, Bookshelf>();
			CreateMap<Bookshelf, BookshelfDto>();
			CreateMap<BookshelfShortDto, Bookshelf>();
			CreateMap<Bookshelf, BookshelfShortDto>();
			CreateMap<BookshelfHelperDto, Bookshelf>();
			CreateMap<Bookshelf, BookshelfHelperDto>();
			CreateMap<BookshelfHelperDto, BookshelfDetailDto>();
			CreateMap<BookshelfDetailDto, BookshelfHelperDto>();
			CreateMap<UserDto, User>();
			CreateMap<User, UserDto>();
			CreateMap(typeof(JsonPatchDocument<>), typeof(JsonPatchDocument<>));
			CreateMap(typeof(Operation<>), typeof(Operation<>));
			CreateMap(typeof(PagedList<>), typeof(PagedList<>));
		}
	}
}
