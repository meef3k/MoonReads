using System;
using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IPublisherRepository
    {
        ICollection<Publisher> GetPublishers();
    }
}
