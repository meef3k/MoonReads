using MoonReads.Dto;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
	public interface IBookRepository
	{
		Book GetBook(int id);
		BookDetailDto GetBookDetails(int id);
		ICollection<BookDetailDto> GetBooks(bool pending);
        bool CreateBook(int[] authorsIds, int[] categoriesIds, Book book);
		bool UpdateBook(int publisherId, int[] authorId, int[] categoryId, Book book);
		bool UpdateBookStatus(Book bookId);
		bool DeleteBook(Book book);
		bool BookExists(int bookId);
        bool Save();
    }
}
