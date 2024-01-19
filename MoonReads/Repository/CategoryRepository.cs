using System.Linq.Expressions;
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
        
        public PagedList<Category> GetCategories(
            string? searchTerm,
            string? sortColumn,
            string? sortOrder,
            int? page,
            int? pageSize)
        {
            IQueryable<Category> categoriesQuery = _context.Categories;

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                categoriesQuery = categoriesQuery.Where(c =>
                    c.Name.ToLower().Contains(searchTerm.ToLower()));
            }

            Expression<Func<Category, object>> keySelector = sortColumn?.ToLower() switch
            {
                "name" => category => category.Name,
                _ => category => category.Id
            };

            categoriesQuery = sortOrder?.ToLower() == "desc" ? categoriesQuery.OrderByDescending(keySelector) : categoriesQuery.OrderBy(keySelector);

            if (page != null && pageSize != null)
            {
                return PagedList<Category>.Create(categoriesQuery, (int)page, (int)pageSize);
            }
            
            return PagedList<Category>.Create(categoriesQuery, 1, _context.Categories.Count());
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
        
        public bool CategoryExists(string categoryName)
        {
            return _context.Categories.Any(c => c.Name == categoryName);
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

