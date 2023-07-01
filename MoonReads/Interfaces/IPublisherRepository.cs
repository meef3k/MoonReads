using System;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IPublisherRepository
    {
        ICollection<Publisher> GetPublishers();
        Publisher GetPublisher(int id);
        Publisher GetPublisher(string name);
        ICollection<Book> GetBookByPublisher(int publisherId);
        bool PublisherExists(int publisherId);
    }
}
