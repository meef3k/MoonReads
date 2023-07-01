using System;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
    }
}
