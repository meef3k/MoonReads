using System;
using MoonReads.Dto;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
	public interface IBookRepository
	{
		ICollection<BookDetailDto> GetBooks();
		BookDetailDto GetBookDetails(int id);
		Book GetBook(int id);
		Book GetBook(string name);
		bool BookExists(int bookId);
        bool CreateBook(int authorId, int categoryId, Book book);
		bool UpdateBook(int publisherId, int authorId, int categoryId, Book book);
		bool DeleteBook(Book book);
        bool Save();
    }
}
