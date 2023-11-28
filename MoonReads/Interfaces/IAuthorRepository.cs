using MoonReads.Dto;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IAuthorRepository
    {
        Author GetAuthor(int id);
        AuthorDto GetAuthorDetail(int id);
        ICollection<AuthorDto> GetAuthors();
        ICollection<BookDetailDto> GetBookByAuthor(int authorId);
        bool CreateAuthor(Author author);
        bool UpdateAuthor(Author author);
        bool DeleteAuthor(Author author);
        bool AuthorExists(int authorId);
        bool Save();
        bool HasBooks(Author author);
    }
}
