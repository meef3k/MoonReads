using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface ICategoryRepository
    {
        Category GetCategory(int id);
        ICollection<Category> GetCategories();
        ICollection<Book> GetBookByCategory(int categoryId);
        ICollection<Author> GetAuthorByCategory(int categoryId);
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(Category category);
        bool CategoryExists(int categoryId);
        bool Save();
    }
}
