using MoonReads.Dto;
using MoonReads.Models;

namespace MoonReads.Interfaces;

public interface IBookshelfRepository
{
    Bookshelf? GetBookshelf(Book book, User user);
    ICollection<BookshelfShortDto> GetBookBookshelves(User user);
    ICollection<BookshelfDetailDto> GetBookshelves(string userId, string status);
    int CreateBookshelf(Bookshelf bookshelf);
    bool UpdateBookshelf(Bookshelf bookshelf);
    bool DeleteBookshelf(Bookshelf bookshelf);
    bool BookshelfExists(Book book, User user);
    bool Save();
}