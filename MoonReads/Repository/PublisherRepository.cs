﻿using MoonReads.Data;
using MoonReads.Dto;
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
        
        public ICollection<BookDetailDto> GetBookByPublisher(int publisherId)
        {
            var books = _context.Books.Where(b => b.Publisher.Id == publisherId).Select(b => b.Id).ToList();
            return _context
                .Books
                .Where(b => books.Contains(b.Id))
                .Select(b => new BookDetailDto
                {
                    Id = b.Id,
                    Title = b.Title,
                    Description = b.Description,
                    ImageUrl = b.ImageUrl,
                    ReleaseDate = b.ReleaseDate.ToString("yyyy'-'MM'-'dd"),
                    Pages = b.Pages,
                    Isbn = b.Isbn,
                    Publisher = new PublisherShortDto
                    {
                        Id = b.Publisher!.Id,
                        Name = b.Publisher!.Name
                    },
                    Rating = b.Rating.Select(r => r.Rate).Any() ? b.Rating.Select(r => r.Rate).Average() : 0,
                    Authors = b.BookAuthors.Select(a => new AuthorShortDto
                    {
                        Id = a.AuthorId,
                        Name = a.Author!.Name
                    }).ToList(),
                    Categories = b.BookCategories.Select(c => new CategoryDto
                    {
                        Id = c.CategoryId,
                        Name = c.Category!.Name
                    }).ToList()
                })
                .ToList();
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

