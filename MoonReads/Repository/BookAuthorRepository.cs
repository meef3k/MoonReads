using MoonReads.Data;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository
{
    public class BookAuthorRepository : IBookAuthorRepository
    {
        private readonly DataContext _context;

        public BookAuthorRepository(DataContext context)
        {
            _context = context;
        }
        
        public ICollection<BookAuthor> GetBooksAuthors()
        {
            return _context.BookAuthors.OrderBy(b => b.Id).ToList();
        }
    }
}