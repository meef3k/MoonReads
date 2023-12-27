using MoonReads.Data;
using MoonReads.Dto;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository;

public class BookshelfRepository : IBookshelfRepository
{
    private readonly DataContext _context;

    public BookshelfRepository(DataContext context)
    {
        _context = context;
    }

    public Bookshelf? GetBookshelf(Book book, User user)
    {
        return _context
            .Bookshelves
            .Where(b => b.User == user)
            .FirstOrDefault(b => b.Book == book);
    }
    
    public ICollection<BookshelfDetailDto> GetBookshelves(string userId, string status)
    {
        return _context
            .Bookshelves
            .Where(b => b.User.Id == userId && b.Status == status)
            .OrderByDescending(b => b.Id)
            .Select(b => new BookshelfDetailDto
            {
                Id = b.Book.Id,
                Title = b.Book.Title,
                ImageUrl = b.Book.ImageUrl,
                Rating = b.Book.Rating.Select(r => r.Rate).Any() ? b.Book.Rating.Select(r => r.Rate).Average() : 0,
                Authors = b.Book.BookAuthors.Select(a => new AuthorShortDto
                {
                    Id = a.AuthorId,
                    Name = a.Author.Name
                }).ToList(),
            })
            .ToList();
    }
    
    public int CreateBookshelf(Bookshelf bookshelf)
    {
        _context.Add(bookshelf);

        return Save() ? bookshelf.Id : 0;
    }

    public bool UpdateBookshelf(Bookshelf bookshelf)
    {
        _context.Update(bookshelf);

        return Save();
    }

    public bool DeleteBookshelf(Bookshelf bookshelf)
    {
        _context.Remove(bookshelf);

        return Save();
    }
    
    public bool BookshelfExists(Book book, User user)
    {
        return _context
            .Bookshelves
            .Where(b => b.User == user)
            .Any(b => b.Book == book);
    }
    
    public bool Save()
    {
        _context.DataVersions.FirstOrDefault(d => d.Table == "Bookshelves")!.Version++;

        var saved = _context.SaveChanges();

        return saved > 0;
    }
}