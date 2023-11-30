using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IBookAuthorRepository
    {
        ICollection<BookAuthor> GetBooksAuthors();
    }
}
