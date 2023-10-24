using MoonReads.Data;
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

        public ICollection<Book> GetBookByAuthor(int authorId)
        {
            return _context.BookAuthors.Where(a => a.AuthorId == authorId).Select(b => b.Book).ToList()!;
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
    }
}

