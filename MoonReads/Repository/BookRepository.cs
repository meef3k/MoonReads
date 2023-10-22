using Microsoft.EntityFrameworkCore;
using MoonReads.Data;
using MoonReads.Dto;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository
{
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
                .Where(b => b.Id == id)
                .Include(b => b.Publisher)
                .Include(b => b.BookAuthors)
                .Include(b => b.BookCategories)
                .FirstOrDefault()!;
        }

        public Book GetBook(string title)
        {
            return _context
                .Books
                .Where(b => b.Title == title)
                .Include(b => b.Publisher)
                .Include(b => b.BookAuthors)
                .Include(b => b.BookCategories)
                .FirstOrDefault()!;
        }

        public BookDetailDto GetBookDetails(int id)
        {
            return _context
                .Books
                .Select(b => new BookDetailDto
                {
                    Id = b.Id,
                    Title = b.Title,
                    Description = b.Description,
                    ImageUrl = b.ImageUrl,
                    ReleaseDate = b.ReleaseDate.ToString(),
                    Pages = b.Pages,
                    Isbn = b.Isbn,
                    Publisher = b.Publisher.Name,
                    Rating = b.Rating.Select(r => r.Rate).Any() ? b.Rating.Select(r => r.Rate).Average() : 0,
                    Authors = b.BookAuthors.Select(a => a.Author!.Name).ToList(),
                    Categories = b.BookCategories.Select(c => c.Category!.Name).ToList()
                })
                .FirstOrDefault(b => b.Id == id)!;
        }

        public ICollection<BookDetailDto> GetBooks()
		{
            return _context
                .Books
                .Select(b => new BookDetailDto
                {
                    Id = b.Id,
                    Title = b.Title,
                    Description = b.Description,
                    ImageUrl = b.ImageUrl,
                    ReleaseDate = b.ReleaseDate.ToString(),
                    Pages = b.Pages,
                    Isbn = b.Isbn,
                    Publisher = b.Publisher.Name,
                    Rating = b.Rating.Select(r => r.Rate).Any() ? b.Rating.Select(r => r.Rate).Average() : 0,
                    Authors = b.BookAuthors.Select(a => a.Author!.Name).ToList(),
                    Categories = b.BookCategories.Select(c => c.Category!.Name).ToList()
                })
                .ToList();
		}

        public bool CreateBook(int authorId, int categoryId, Book book)
        {
            var author = _context.Authors.FirstOrDefault(a => a.Id == authorId);
            var category = _context.Categories.FirstOrDefault(c => c.Id == categoryId);

            var bookAuthor = new BookAuthor()
            {
                Author = author,
                Book = book,
            };

            _context.Add(bookAuthor);

            var bookCategory = new BookCategory()
            {
                Category = category,
                Book = book,
            };

            _context.Add(bookCategory);

            _context.Add(book);

            return Save();
        }

        public bool UpdateBook(int publisherId, int authorId, int categoryId, Book book)
        {
            _context.Update(book);

            return Save();
        }

        public bool DeleteBook(Book book)
        {
            _context.Remove(book);

            return Save();
        }
        
        public bool BookExists(int bookId)
        {
            return _context.Books.Any(b => b.Id == bookId);
        }
        
        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0;
        }
    }
}

