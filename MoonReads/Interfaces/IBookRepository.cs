using System;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
	public interface IBookRepository
	{
		ICollection<Book> GetBooks();
	}
}
