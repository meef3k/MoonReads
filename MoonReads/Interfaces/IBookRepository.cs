using MoonReads.Dto;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
	public interface IBookRepository
	{
		Book GetBook(int id);
		Book GetBook(string name);
		BookDetailDto GetBookDetails(int id);
		ICollection<BookDetailDto> GetBooks();
        bool CreateBook(int authorId, int categoryId, Book book);
		bool UpdateBook(int publisherId, int authorId, int categoryId, Book book);
		bool DeleteBook(Book book);
		bool BookExists(int bookId);
        bool Save();
    }
}
