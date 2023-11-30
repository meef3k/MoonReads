using MoonReads.Data;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository
{
    public class AuthorCategoryRepository : IAuthorCategoryRepository
    {
        private readonly DataContext _context;

        public AuthorCategoryRepository(DataContext context)
        {
            _context = context;
        }
        
        public ICollection<AuthorCategory> GetAuthorsCategories()
        {
            return _context.AuthorCategories.OrderBy(b => b.Id).ToList();
        }
    }
}
