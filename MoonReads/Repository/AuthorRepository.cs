using System.Linq.Expressions;
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
        
        public bool AuthorExists(int authorId)
        {
            return _context.Authors.Any(a => a.Id == authorId);
        }
        
        public bool AuthorExists(string authorName)
        {
            return _context.Authors.Any(a => a.Name == authorName);
        }

        public Author GetAuthor(int id)
        {
            return _context.Authors.FirstOrDefault(a => a.Id == id)!;
        }
        
        public AuthorDetailDto GetAuthorDetail(int id)
        {
            var query = _context.Authors
                .Where(a => a.Id == id)
                .SelectMany(a => a.BookAuthors)
                .SelectMany(ba => ba.Book.Rating);
            return _context
                .Authors
                .Select(a=> new AuthorDetailDto
                {
                    Id = a.Id,
                    Name = a.Name,
                    Description = a.Description,
                    ImageUrl = a.ImageUrl,
                    Rating = query.Any() ? query.Average(r => r.Rate) : 0
                })
                .FirstOrDefault(a => a.Id == id)!;
        }

        public PagedList<AuthorDetailDto> GetAuthors(
            string? searchTerm,
            string? sortColumn,
            string? sortOrder,
            int? page,
            int? pageSize)
        {
            var authorsQuery = _context.Authors
                .Select(a => new AuthorDetailDto
                {
                    Id = a.Id,
                    Name = a.Name,
                    Description = a.Description,
                    ImageUrl = a.ImageUrl,
                    Rating = a.BookAuthors.SelectMany(ba => ba.Book.Rating).Any() 
                        ? a.BookAuthors.SelectMany(ba => ba.Book.Rating).Average(r => r.Rate) 
                        : 0
                }).AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                authorsQuery = authorsQuery.Where(a =>
                    a.Name.ToLower().Contains(searchTerm.ToLower()));
            }

            Expression<Func<AuthorDetailDto, object>> keySelector = sortColumn?.ToLower() switch
            {
                "name" => author => author.Name,
                "description" => author => author.Description,
                "rating" => author => author.Rating,
                _ => publisher => publisher.Id
            };

            authorsQuery = sortOrder?.ToLower() == "desc" ? authorsQuery.OrderByDescending(keySelector) : authorsQuery.OrderBy(keySelector);

            if (page != null && pageSize != null)
            {
                return PagedList<AuthorDetailDto>.Create(authorsQuery, (int)page, (int)pageSize);
            }
            
            return PagedList<AuthorDetailDto>.Create(authorsQuery, 1, _context.Authors.Count());
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
                        Id = b.Publisher.Id,
                        Name = b.Publisher.Name
                    },
                    Rating = b.Rating.Select(r => r.Rate).Any() ? b.Rating.Select(r => r.Rate).Average() : 0,
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
                })
                .ToList();
        }

        public int CreateAuthor(Author author)
        {
            _context.Add(author);

            return Save() ? author.Id : 0;
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

