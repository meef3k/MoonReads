using System;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IAuthorRepository
    {
        ICollection<Author> GetAuthors();
    }
}
