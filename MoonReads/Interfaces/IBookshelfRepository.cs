using MoonReads.Dto;
using MoonReads.Dto.Bookshelf;
using MoonReads.Models;

namespace MoonReads.Interfaces;

public interface IBookshelfRepository
{
    Bookshelf? GetBookshelf(Book book, User user);
    PagedList<BookshelfHelperDto> GetBookshelves(
        string? searchTerm,
        Dictionary<string, string>? filterTerms,
        string? sortColumn,
        string? sortOrder,
        int? page,
        int? pageSize);
    int CreateBookshelf(Bookshelf bookshelf);
    bool UpdateBookshelf(Bookshelf bookshelf);
    bool DeleteBookshelf(Bookshelf bookshelf);
    bool BookshelfExists(Book book, User user);
    bool Save();
}