using MoonReads.Dto;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface ICategoryRepository
    {
        Category GetCategory(int id);
        PagedList<Category> GetCategories(
            string? searchTerm,
            string? sortColumn,
            string? sortOrder,
            int? page,
            int? pageSize);
        ICollection<BookDetailDto> GetBookByCategory(int categoryId);
        ICollection<Author> GetAuthorByCategory(int categoryId);
        int CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(Category category);
        bool CategoryExists(int categoryId);
        bool CategoryExists(string categoryName);
        bool Save();
        bool HasBooks(Category category);
        bool HasAuthors(Category category);
    }
}
