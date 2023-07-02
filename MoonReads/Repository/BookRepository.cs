using System;
using Microsoft.EntityFrameworkCore;
using MoonReads.Data;
using MoonReads.Dto;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository
{
    public class BookRepository : IBookRepository
	{
		private readonly DataContext _context;

		public BookRepository(DataContext context)
		{
			_context = context;
		}

        public Book GetBook(int id)
        {
            return _context.Books.Include(b => b.Publisher).Where(b => b.Id == id).FirstOrDefault();
        }

        public Book GetBook(string name)
        {
            return _context.Books.Where(b => b.Name == name).FirstOrDefault();
        }

        public ICollection<Book> GetBooks()
		{
            return _context.Books.OrderBy(b => b.Id).ToList();
		}

        public bool BookExists(int bookId)
        {
            return _context.Books.Any(b => b.Id == bookId);
        }

        public bool CreateBook(int authorId, int categoryId, Book book)
        {
            var author = _context.Authors.Where(a => a.Id == authorId).FirstOrDefault();
            var category = _context.Categories.Where(c => c.Id == categoryId).FirstOrDefault();

            var bookAuthor = new BookAuthor()
            {
                Author = author,
                Book = book,
            };

            _context.Add(bookAuthor);

            var bookCategory = new BookCategory()
            {
                Category = category,
                Book = book,
            };

            _context.Add(bookCategory);

            _context.Add(book);

            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;
        }

        public bool UpdateBook(int publisherId, int authorId, int categoryId, Book book)
        {
            _context.Update(book);

            return Save();
        }

        public bool DeleteBook(Book book)
        {
            _context.Remove(book);

            return Save();
        }
    }
}

