using System;
using System.Net;
using MoonReads.Data;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public bool CategoryExists(int categoryId)
        {
            return _context.Books.Any(c => c.Id == categoryId);
        }

        public ICollection<Author> GetAuthorByCategory(int categoryId)
        {
            return _context.AuthorCategories.Where(c => c.CategoryId == categoryId).Select(a => a.Author).ToList();
        }

        public ICollection<Book> GetBookByCategory(int categoryId)
        {
            return _context.BookCategories.Where(c => c.CategoryId == categoryId).Select(b => b.Book).ToList();
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.OrderBy(c => c.Id).ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Where(c => c.Id == id).FirstOrDefault();
        }

        public Category GetCategory(string name)
        {
            return _context.Categories.Where(c => c.Name == name).FirstOrDefault();
        }
    }
}

