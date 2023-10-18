using System;
using System.Linq;
using MoonReads.Data;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository
{
	public class RatingRepository : IRatingRepository
	{
        private readonly DataContext _context;

        public RatingRepository(DataContext context)
        {
            _context = context;
        }

        public double GetRatingsForBook(Book book)
        {
            return _context.Ratings.Where(r => r.Book == book).Average(r => r.Rate);
        }

        public bool CreateRating(Rating rating)
        {
            _context.Add(rating);

            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;
        }

        public bool UpdateRating(Rating rating)
        {
            _context.Update(rating);

            return Save();
        }

        public bool DeleteRating(Rating rating)
        {
            _context.Remove(rating);

            return Save();
        }
    }
}
