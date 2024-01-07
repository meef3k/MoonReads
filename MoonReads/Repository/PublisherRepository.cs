using System.Linq.Expressions;
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
        
        public PagedList<Publisher> GetPublishers(
            string? searchTerm,
            string? sortColumn,
            string? sortOrder,
            int? page,
            int? pageSize)
        {
            IQueryable<Publisher> publishersQuery = _context.Publishers;

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                publishersQuery = publishersQuery.Where(p =>
                    p.Name.ToLower().Contains(searchTerm.ToLower()));
            }

            Expression<Func<Publisher, object>> keySelector = sortColumn?.ToLower() switch
            {
                "name" => publisher => publisher.Name,
                "description" => publisher => publisher.Description,
                _ => publisher => publisher.Id
            };

            publishersQuery = sortOrder?.ToLower() == "desc" ? publishersQuery.OrderByDescending(keySelector) : publishersQuery.OrderBy(keySelector);

            if (page != null && pageSize != null)
            {
                return PagedList<Publisher>.Create(publishersQuery, (int)page, (int)pageSize);
            }
            
            return PagedList<Publisher>.Create(publishersQuery, 1, _context.Publishers.Count());
        }

        public int CreatePublisher(Publisher publisher)
        {
            _context.Add(publisher);

            return Save() ? publisher.Id : 0;
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
        
        public bool PublisherExists(string publisherName)
        {
            return _context.Publishers.Any(p => p.Name == publisherName);
        }
        
        public bool Save()
        {
            _context.DataVersions.FirstOrDefault(d => d.Table == "Publishers")!.Version++;
            
            var saved = _context.SaveChanges();

            return saved > 0;
        }
        
        public bool HasBooks(Publisher publisher)
        {
            return _context.Books.Any(b => b.PublisherId == publisher.Id);
        }
    }
}

