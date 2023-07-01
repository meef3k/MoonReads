using System;
using MoonReads.Data;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DataContext _context;

        public AuthorRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Author> GetAuthors()
        {
            return _context.Authors.OrderBy(b => b.Id).ToList();
        }
    }
}

