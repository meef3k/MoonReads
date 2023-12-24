using MoonReads.Data;
using MoonReads.Dto;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }
        
        public Category GetCategory(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id)!;
        }
        
        public ICollection<Category> GetCategories()
        {
            return _context.Categories.OrderBy(c => c.Id).ToList();
        }

        public ICollection<Author> GetAuthorByCategory(int categoryId)
        {
            return _context.AuthorCategories.Where(c => c.CategoryId == categoryId).Select(a => a.Author).ToList()!;
        }

        public ICollection<BookDetailDto> GetBookByCategory(int categoryId)
        {
            var books = _context.BookCategories.Where(c => c.CategoryId == categoryId).Select(b => b.Book.Id).ToList();
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
        
        public int CreateCategory(Category category)
        {
            _context.Add(category);

            return Save() ? category.Id : 0;
        }

        public bool UpdateCategory(Category category)
        {
            _context.Update(category);

            return Save();
        }
        
        public bool DeleteCategory(Category category)
        {
            _context.Remove(category);

            return Save();
        }
        
        public bool CategoryExists(int categoryId)
        {
            return _context.Categories.Any(c => c.Id == categoryId);
        }
        
        public bool Save()
        {
            _context.DataVersions.FirstOrDefault(d => d.Table == "Categories")!.Version++;

            var saved = _context.SaveChanges();

            return saved > 0;
        }
        
        public bool HasBooks(Category category)
        {
            return _context.BookCategories.Any(bc => bc.CategoryId == category.Id);
        }
        
        public bool HasAuthors(Category category)
        {
            return _context.AuthorCategories.Any(ac => ac.CategoryId == category.Id);
        }
    }
}

