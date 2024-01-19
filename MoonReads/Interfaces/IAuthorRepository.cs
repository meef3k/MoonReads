using MoonReads.Dto;
using MoonReads.Dto.Author;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IAuthorRepository
    {
        Author GetAuthor(int id);
        AuthorDetailDto GetAuthorDetail(int id);
        PagedList<AuthorDetailDto> GetAuthors(
            string? searchTerm,
            string? sortColumn,
            string? sortOrder,
            int? page,
            int? pageSize);
        int CreateAuthor(Author author);
        bool UpdateAuthor(Author author);
        bool DeleteAuthor(Author author);
        bool AuthorExists(int authorId);
        bool AuthorExists(string authorName);
        bool Save();
        bool HasBooks(Author author);
    }
}
