using System;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        Category GetCategory(string name);
        ICollection<Book> GetBookByCategory(int categoryId);
        ICollection<Author> GetAuthorByCategory(int categoryId);
        bool CategoryExists(int categoryId);
    }
}
