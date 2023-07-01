using System;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IAuthorRepository
    {
        ICollection<Author> GetAuthors();
        Author GetAuthor(int id);
        ICollection<Book> GetBookByAuthor(int authorId);
        bool AuthorExists(int authorId);
    }
}
