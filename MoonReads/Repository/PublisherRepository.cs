using System;
using System.Net;
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

        public ICollection<Book> GetBookByPublisher(int publisherId)
        {
            return _context.Books.Where(b => b.Publisher.Id == publisherId).ToList();
        }

        public Publisher GetPublisher(int id)
        {
            return _context.Publishers.Where(p => p.Id == id).FirstOrDefault();
        }

        public Publisher GetPublisher(string name)
        {
            return _context.Publishers.Where(p => p.Name == name).FirstOrDefault();
        }

        public ICollection<Publisher> GetPublishers()
        {
            return _context.Publishers.OrderBy(p => p.Id).ToList();
        }

        public bool PublisherExists(int publisherId)
        {
            return _context.Publishers.Any(p => p.Id == publisherId);
        }
    }
}

