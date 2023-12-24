using MoonReads.Dto;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IPublisherRepository
    {
        Publisher GetPublisher(int id);
        ICollection<Publisher> GetPublishers();
        ICollection<BookDetailDto> GetBookByPublisher(int publisherId);
        int CreatePublisher(Publisher publisher);
        bool UpdatePublisher(Publisher publisher);
        bool DeletePublisher(Publisher publisher);
        bool PublisherExists(int publisherId);
        bool Save();
        bool HasBooks(Publisher publisher);
    }
}
