﻿using MoonReads.Data;
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
            var ratingExist = _context.Ratings.Where(b => b.Book == rating.Book)
                .FirstOrDefault(u => u.User == rating.User);
            if (ratingExist != null)
            {
                _context.Remove(ratingExist);
            }
            _context.Add(rating);

            return Save();
        }
        
        public bool Save()
        {
            _context.DataVersions.FirstOrDefault(d => d.Table == "Ratings")!.Version++;

            var saved = _context.SaveChanges();

            return saved > 0;
        }
    }
}
