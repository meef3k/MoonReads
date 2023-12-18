using System.Diagnostics.CodeAnalysis;
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
                .FirstOrDefault(b => b.Id == id)!;
        }

        public BookDetailDto GetBookDetails(int id)
        {
            return _context
                .Books
                .Where(b => b.Pending == false)
                .Select(b => new BookDetailDto
                {
                    Id = b.Id,
                    Title = b.Title,
                    Description = b.Description,
                    ImageUrl = b.ImageUrl,
                    ReleaseDate = b.ReleaseDate.ToString("yyyy'-'MM'-'dd"),
                    Pages = b.Pages,
                    Isbn = b.Isbn,
                    Publisher = new PublisherShortDto
                    {
                        Id = b.Publisher!.Id,
                        Name = b.Publisher!.Name
                    },
                    Rating = b.Rating.Select(r => r.Rate).Any() ? b.Rating.Select(r => r.Rate).Average() : 0,
                    Authors = b.BookAuthors.Select(a => new AuthorShortDto
                    {
                        Id = a.AuthorId,
                        Name = a.Author!.Name
                    }).ToList(),
                    Categories = b.BookCategories.Select(c => new CategoryDto
                    {
                        Id = c.CategoryId,
                        Name = c.Category!.Name
                    }).ToList()
                })
                .FirstOrDefault(b => b.Id == id)!;
        }
        
        public ICollection<BookDetailDto> GetBooks(bool pending)
		{
            return _context
                .Books
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
                    Publisher = new PublisherShortDto
                    {
                        Id = b.Publisher!.Id,
                        Name = b.Publisher!.Name
                    },
                    Rating = b.Rating.Select(r => r.Rate).Any() ? b.Rating.Select(r => r.Rate).Average() : 0,
                    Authors = b.BookAuthors.Select(a => new AuthorShortDto
                    {
                        Id = a.AuthorId,
                        Name = a.Author!.Name
                    }).ToList(),
                    Categories = b.BookCategories.Select(c => new CategoryDto
                    {
                        Id = c.CategoryId,
                        Name = c.Category!.Name
                    }).ToList()
                })
                .ToList();
		}

        public bool CreateBook(int[] authorsIds, int[] categoriesIds, Book book)
        {
            AddBookAuthors(authorsIds, book);
            
            AddBookCategories(categoriesIds, book);

            _context.Add(book);

            return Save();
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
                    Author = author,
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
                    Category = category,
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
    }
}

