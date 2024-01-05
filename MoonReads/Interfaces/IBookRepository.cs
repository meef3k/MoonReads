using MoonReads.Dto;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
	public interface IBookRepository
	{
		Book GetBook(int id);
		BookDetailDto GetBookDetails(int id);
		PagedList<BookDetailDto> GetBooks(bool pending,
			string? searchTerms,
			Dictionary<string, string[]>? filterTerms,
			string? sortColumn,
			string? sortOrder,
			int? page,
			int? pageSize);
        int CreateBook(int[] authorsIds, int[] categoriesIds, Book book);
		bool UpdateBook(int publisherId, int[] authorId, int[] categoryId, Book book);
		bool UpdateBookStatus(Book bookId);
		bool DeleteBook(Book book);
		bool BookExists(int bookId);
		bool BookExists(string bookTitle);
        bool Save();
    }
}
