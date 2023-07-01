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
    }
}

