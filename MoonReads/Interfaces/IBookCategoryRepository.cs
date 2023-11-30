using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IBookCategoryRepository
    {
        ICollection<BookCategory> GetBooksCategories();
    }
}