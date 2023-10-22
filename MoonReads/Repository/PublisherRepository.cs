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
        
        public Publisher GetPublisher(int id)
        {
            return _context.Publishers.FirstOrDefault(p => p.Id == id)!;
        }
        
        public ICollection<Publisher> GetPublishers()
        {
            return _context.Publishers.OrderBy(p => p.Id).ToList();
        }
        
        public ICollection<Book> GetBookByPublisher(int publisherId)
        {
            return _context.Books.Where(b => b.Publisher.Id == publisherId).ToList();
        }

        public bool CreatePublisher(Publisher publisher)
        {
            _context.Add(publisher);

            return Save();
        }

        public bool DeletePublisher(Publisher publisher)
        {
            _context.Remove(publisher);

            return Save();
        }

        public bool UpdatePublisher(Publisher publisher)
        {
            _context.Update(publisher);

            return Save();
        }
        
        public bool PublisherExists(int publisherId)
        {
            return _context.Publishers.Any(p => p.Id == publisherId);
        }
        
        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0;
        }
    }
}

