using MoonReads.Data;
using MoonReads.Dto;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DataContext _context;

        public AuthorRepository(DataContext context)
        {
            _context = context;
        }
        
        public bool AuthorExists(int bookId)
        {
            return _context.Authors.Any(a => a.Id == bookId);
        }

        public Author GetAuthor(int id)
        {
            return _context.Authors.FirstOrDefault(a => a.Id == id)!;
        }

        public ICollection<Author> GetAuthors()
        {
            return _context.Authors.OrderBy(a => a.Id).ToList();
        }

        public ICollection<BookDetailDto> GetBookByAuthor(int authorId)
        {
            var books = _context.BookAuthors.Where(a => a.AuthorId == authorId).Select(b => b.Book.Id).ToList();
            return _context
                .Books
                .Where(b => books.Contains(b.Id))
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

        public bool CreateAuthor(Author author)
        {
            _context.Add(author);

            return Save();
        }

        public bool Save()
        {
            _context.DataVersions.FirstOrDefault(d => d.Table == "Authors")!.Version++;
            _context.DataVersions.FirstOrDefault(d => d.Table == "AuthorCategories")!.Version++;
            
            var saved = _context.SaveChanges();

            return saved > 0;
        }

        public bool UpdateAuthor(Author author)
        {
            _context.Update(author);

            return Save();
        }

        public bool DeleteAuthor(Author author)
        {
            _context.Remove(author);

            return Save();
        }

        public bool HasBooks(Author author)
        {
            return _context.BookAuthors.Any(ba => ba.AuthorId == author.Id);
        }
    }
}

