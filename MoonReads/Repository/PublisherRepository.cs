using System;
using MoonReads.Data;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly DataContext _context;

        public PublisherRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Publisher> GetPublishers()
        {
            return _context.Publishers.OrderBy(b => b.Id).ToList();
        }
    }
}

