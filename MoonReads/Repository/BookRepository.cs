using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MoonReads.Data;
using MoonReads.Dto;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository;

public class BookRepository : IBookRepository
{
    private readonly DataContext _context;

    public BookRepository(DataContext context)
    {
        _context = context;
    }

    public Book GetBook(int id)
    {
        return _context
            .Books
            .FirstOrDefault(b => b.Id == id)!;
    }

    public BookDetailDto GetBookDetails(int id)
    {
        IQueryable<Book> booksQuery = _context.Books
            .Include(b => b.BookAuthors)
            .ThenInclude(ba => ba.Author)
            .Include(b => b.Publisher)
            .Include(b => b.Rating)
            .Include(b => b.BookCategories)
            .ThenInclude(bc => bc.Category);
        
        return MapToBookDetailDto(booksQuery, false).FirstOrDefault(b => b.Id == id)!;
    }
        
    public PagedList<BookDetailDto> GetBooks(
        bool pending,
        string? searchTerm,
        Dictionary<string, string>? filterTerms,
        string? sortColumn,
        string? sortOrder,
        int? page,
        int? pageSize)
    {
        IQueryable<Book> query = _context.Books
            .Include(b => b.BookAuthors)
            .ThenInclude(ba => ba.Author)
            .Include(b => b.Publisher)
            .Include(b => b.Rating)
            .Include(b => b.BookCategories)
            .ThenInclude(bc => bc.Category);
        
        var booksQuery = MapToBookDetailDto(query, pending);

        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            booksQuery = booksQuery
                .Where(b =>
                    b.Title.ToLower().Contains(searchTerm.ToLower()) ||
                    b.Authors.Any(a => a.Name.ToLower().Contains(searchTerm.ToLower())) ||
                    b.Publisher.Name.ToLower().Contains(searchTerm.ToLower()) ||
                    b.Categories.Any(a => a.Name.ToLower().Contains(searchTerm.ToLower())) ||
                    b.Isbn.ToLower().Contains(searchTerm.ToLower()));
        }

        if (!filterTerms.IsNullOrEmpty())
        {
            var startDate = DateOnly.MinValue;
            var endDate = DateOnly.MaxValue;
            var minRating = 0.0;
            var maxRating = 5.0;
            int? authorId = null;
            int? categoryId = null;
            int? publisherId = null;

            foreach (var filterTerm in filterTerms!)
            {
                switch (filterTerm.Key)
                {
                    case "startDate":
                        DateOnly.TryParse(filterTerm.Value, out startDate);
                        break;

                    case "endDate":
                        DateOnly.TryParse(filterTerm.Value, out endDate);
                        break;

                    case "minRating":
                        double.TryParse(filterTerm.Value, out minRating);
                        break;

                    case "maxRating":
                        double.TryParse(filterTerm.Value, out maxRating);
                        break;

                    case "authorId":
                        int.TryParse(filterTerm.Value, out var parsedAuthorId);
                        authorId = parsedAuthorId;
                        break;

                    case "categoryId":
                        int.TryParse(filterTerm.Value, out var parsedCategoryId);
                        categoryId = parsedCategoryId;
                        break;

                    case "publisherId":
                        int.TryParse(filterTerm.Value, out var parsedPublisherId);
                        publisherId = parsedPublisherId;
                        break;
                }
            }

            booksQuery = booksQuery
                .AsEnumerable()
                .Where(b =>
                    (startDate == DateOnly.MinValue || DateOnly.Parse(b.ReleaseDate) >= startDate) &&
                    (endDate == DateOnly.MaxValue || DateOnly.Parse(b.ReleaseDate) <= endDate) &&
                    b.Rating >= minRating &&
                    b.Rating <= maxRating &&
                    (authorId == null || b.Authors.Any(a => a.Id == authorId)) &&
                    (categoryId == null || b.Categories.Any(c => c.Id == categoryId)) &&
                    (publisherId == null || b.Publisher.Id == publisherId)
                )
                .AsQueryable();
        }

        Expression<Func<BookDetailDto, object>> keySelector = sortColumn?.ToLower() switch
        {
            "title" => book => book.Title,
            "releasedate" => book => book.ReleaseDate,
            "authors" => book => book.Authors,
            "publisher" => book => book.Publisher.Name,
            "categories" => book => book.Categories,
            "isbn" => book => book.Isbn,
            "rating" => book => book.Rating,
            "totalratings" => book => book.TotalRatings,
            "totalreviews" => book => book.TotalReviews,
            _ => book => book.Id
        };

        booksQuery = sortOrder?.ToLower() == "desc" ? booksQuery.OrderByDescending(keySelector) : booksQuery.OrderBy(keySelector);

        if (page != null && pageSize != null)
        {
            return PagedList<BookDetailDto>.Create(booksQuery, (int)page, (int)pageSize);
        }
            
        return PagedList<BookDetailDto>.Create(booksQuery, 1, _context.Books.Count());
    }

    public int CreateBook(int[] authorsIds, int[] categoriesIds, Book book)
    {
        AddBookAuthors(authorsIds, book);
            
        AddBookCategories(categoriesIds, book);

        _context.Add(book);

        return Save() ? book.Id : 0;
    }

    public bool UpdateBook(int publisherId, int[] authorsIds, int[] categoriesIds, Book book)
    {
        DeleteBookAuthors(book);
            
        DeleteBookCategories(book);
            
        AddBookAuthors(authorsIds, book);
            
        AddBookCategories(categoriesIds, book);
            
        var publisher = _context.Publishers.FirstOrDefault(p => p.Id == publisherId);

        book.Publisher = publisher!;

        _context.Update(book);

        return Save();
    }
        
    public bool UpdateBookStatus(Book book)
    {
        _context.Update(book);

        return Save();
    }

    public bool DeleteBook(Book book)
    {
        DeleteBookAuthors(book);
            
        DeleteBookCategories(book);

        _context.Remove(book);

        return Save();
    }
        
    public bool BookExists(int bookId)
    {
        return _context.Books.Any(b => b.Id == bookId);
    }
        
    public bool BookExists(string bookTitle)
    {
        return _context.Books.Any(b => b.Title == bookTitle);
    }
        
    public bool Save()
    {
        _context.DataVersions.FirstOrDefault(d => d.Table == "Books")!.Version++;
        _context.DataVersions.FirstOrDefault(d => d.Table == "BookAuthors")!.Version++;
        _context.DataVersions.FirstOrDefault(d => d.Table == "BookCategories")!.Version++;

        var saved = _context.SaveChanges();

        return saved > 0;
    }

    private void AddBookAuthors(int[] authorsIds, Book book)
    {
        foreach (int authorId in authorsIds)
        {
            var author = _context.Authors.FirstOrDefault(a => a.Id == authorId);
            var bookAuthor = new BookAuthor()
            {
                Author = author!,
                Book = book
            };
            _context.Add(bookAuthor);
        }
    }

    private void AddBookCategories(int[] categoriesIds, Book book)
    {
        foreach (int categoryId in categoriesIds)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == categoryId);
            var bookCategory = new BookCategory()
            {
                Category = category!,
                Book = book
            };

            _context.Add(bookCategory);
        }
    }

    private void DeleteBookAuthors(Book book)
    {
        var bookAuthorRecords = _context.BookAuthors
            .Where(ba => ba.BookId == book.Id)
            .ToList();

        foreach (var bookAuthorRecord in bookAuthorRecords)
        {
            _context.BookAuthors.Remove(bookAuthorRecord);
        }
    }
        
    private void DeleteBookCategories(Book book)
    {
        var bookCategoryRecords = _context.BookCategories
            .Where(bc => bc.BookId == book.Id)
            .ToList();

        foreach (var bookCategoryRecord in bookCategoryRecords)
        {
            _context.BookCategories.Remove(bookCategoryRecord);
        }
    }
        
    private static IQueryable<BookDetailDto> MapToBookDetailDto(IQueryable<Book> books, bool pending)
    {
        return books
            .Where(b => b.Pending == pending)
            .Select(b => new BookDetailDto
            {
                Id = b.Id,
                Title = b.Title,
                Description = b.Description,
                ImageUrl = b.ImageUrl,
                ReleaseDate = b.ReleaseDate.ToString("yyyy'-'MM'-'dd"),
                Pages = b.Pages,
                Isbn = b.Isbn,
                Rating = b.Rating.Select(r => r.Rate).Any() ? b.Rating.Select(r => r.Rate).Average() : 0,
                TotalRatings = b.Rating.Any() ? b.Rating.Count : 0,
                TotalReviews = b.Rating.Count(r => r.ReviewId != null),
                Publisher = new PublisherShortDto
                {
                    Id = b.Publisher.Id,
                    Name = b.Publisher.Name
                },
                Authors = b.BookAuthors.Select(a => new AuthorShortDto
                {
                    Id = a.AuthorId,
                    Name = a.Author.Name
                }).ToList(),
                Categories = b.BookCategories.Select(c => new CategoryDto
                {
                    Id = c.CategoryId,
                    Name = c.Category.Name
                }).ToList()
            });
    }
}