using System.Linq.Expressions;
using Microsoft.IdentityModel.Tokens;
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
    
    public PagedList<BookshelfHelperDto> GetBookshelves(
        string? searchTerm,
        Dictionary<string, string>? filterTerms,
        string? sortColumn,
        string? sortOrder,
        int? page,
        int? pageSize)
    {
        IQueryable<BookshelfHelperDto> bookshelfQuery = _context.Bookshelves
            .Select(b => new BookshelfHelperDto
            {
                Id = b.Book.Id,
                UserId = b.User.Id,
                Status = b.Status,
                Title = b.Book.Title,
                ImageUrl = b.Book.ImageUrl,
                Rating = b.Book.Rating.Select(r => r.Rate).Any() ? b.Book.Rating.Select(r => r.Rate).Average() : 0,
                TotalRatings = b.Book.Rating.Any() ? b.Book.Rating.Count : 0,
                ReleaseDate = b.Book.ReleaseDate.ToString("yyyy'-'MM'-'dd"),
                Authors = b.Book.BookAuthors.Select(a => new AuthorShortDto
                {
                    Id = a.AuthorId,
                    Name = a.Author.Name
                }).ToList()
            });

        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            bookshelfQuery = bookshelfQuery
                .Where(b =>
                    b.Title.ToLower().Contains(searchTerm.ToLower()) ||
                    b.Authors.Select(a => a.Name.ToLower()).Contains(searchTerm.ToLower()));
        }

        if (!filterTerms.IsNullOrEmpty())
        {
            var userId = string.Empty;
            var status = string.Empty;

            foreach (var filterTerm in filterTerms!)
            {
                switch (filterTerm.Key)
                {
                    case "userId":
                        userId = filterTerm.Value;
                        break;

                    case "status":
                        status = filterTerm.Value;
                        break;
                }
            }

            bookshelfQuery = bookshelfQuery
                .Where(b =>
                    b.UserId == userId &&
                    (string.IsNullOrEmpty(status) || b.Status == status));
        }

        Expression<Func<BookshelfHelperDto, object>> keySelector = sortColumn?.ToLower() switch
        {
            "title" => bookshelf => bookshelf.Title,
            "rating" => bookshelf => bookshelf.Rating,
            "popularity" => bookshelf => bookshelf.TotalRatings,
            "releaseDate" => bookshelf => DateOnly.Parse(bookshelf.ReleaseDate),
            _ => bookshelf => bookshelf.Id
        };

        bookshelfQuery = sortOrder?.ToLower() == "desc" ? bookshelfQuery.OrderByDescending(keySelector) : bookshelfQuery.OrderBy(keySelector);

        if (page != null && pageSize != null)
        {
            return PagedList<BookshelfHelperDto>.Create(bookshelfQuery, (int)page, (int)pageSize);
        }
            
        return PagedList<BookshelfHelperDto>.Create(bookshelfQuery, 1, _context.Books.Count());
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