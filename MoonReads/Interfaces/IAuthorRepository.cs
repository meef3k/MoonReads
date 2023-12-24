using MoonReads.Dto;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IAuthorRepository
    {
        Author GetAuthor(int id);
        AuthorDetailDto GetAuthorDetail(int id);
        ICollection<AuthorDetailDto> GetAuthors();
        ICollection<BookDetailDto> GetBookByAuthor(int authorId);
        int CreateAuthor(Author author);
        bool UpdateAuthor(Author author);
        bool DeleteAuthor(Author author);
        bool AuthorExists(int authorId);
        bool Save();
        bool HasBooks(Author author);
    }
}
