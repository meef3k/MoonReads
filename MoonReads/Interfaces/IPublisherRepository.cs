using MoonReads.Dto;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IPublisherRepository
    {
        Publisher GetPublisher(int id);
        PagedList<Publisher> GetPublishers(
            string? searchTerm,
            string? sortColumn,
            string? sortOrder,
            int? page,
            int? pageSize);
        ICollection<BookDetailDto> GetBookByPublisher(int publisherId);
        int CreatePublisher(Publisher publisher);
        bool UpdatePublisher(Publisher publisher);
        bool DeletePublisher(Publisher publisher);
        bool PublisherExists(int publisherId);
        bool PublisherExists(string publisherName);
        bool Save();
        bool HasBooks(Publisher publisher);
    }
}
