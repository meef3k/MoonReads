using MoonReads.Data;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository
{
    public class BookCategoryRepository : IBookCategoryRepository
    {
        private readonly DataContext _context;

        public BookCategoryRepository(DataContext context)
        {
            _context = context;
        }
        
        public ICollection<BookCategory> GetBooksCategories()
        {
            return _context.BookCategories.OrderBy(b => b.Id).ToList();
        }
    }
}