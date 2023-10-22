using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IAuthorRepository
    {
        Author GetAuthor(int id);
        ICollection<Author> GetAuthors();
        ICollection<Book> GetBookByAuthor(int authorId);
        bool CreateAuthor(Author author);
        bool UpdateAuthor(Author author);
        bool DeleteAuthor(Author author);
        bool AuthorExists(int authorId);
        bool Save();
    }
}
