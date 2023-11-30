using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IAuthorCategoryRepository
    {
        ICollection<AuthorCategory> GetAuthorsCategories();
    }
}
