using System;
using MoonReads.Data;
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

		public ICollection<Book> GetBooks()
		{
			return _context.Books.OrderBy(b => b.Id).ToList();
		}
	}
}

