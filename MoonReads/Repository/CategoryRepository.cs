using MoonReads.Data;
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

        public ICollection<Book> GetBookByCategory(int categoryId)
        {
            return _context.BookCategories.Where(c => c.CategoryId == categoryId).Select(b => b.Book).ToList()!;
        }
        
        public bool CreateCategory(Category category)
        {
            _context.Add(category);

            return Save();
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
    }
}

