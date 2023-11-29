using Bogus;
using Microsoft.EntityFrameworkCore;
using MoonReads.Models;

namespace MoonReads.Data
{
    public static class ModelBuilderExtensions
    {
        public static void SeedDataVersionTable(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataVersion>()
                .HasData(
                    new DataVersion { Id = 1, Table = "Authors", Version = 0 },
                    new DataVersion { Id = 2, Table = "Books", Version = 0 },
                    new DataVersion { Id = 3, Table = "Categories", Version = 0 },
                    new DataVersion { Id = 4, Table = "Publishers", Version = 0 },
                    new DataVersion { Id = 5, Table = "AuthorCategories", Version = 0 },
                    new DataVersion { Id = 6, Table = "BookAuthors", Version = 0 },
                    new DataVersion { Id = 7, Table = "BookCategories", Version = 0 },
                    new DataVersion { Id = 8, Table = "Ratings", Version = 0 },
                    new DataVersion { Id = 9, Table = "Review", Version = 0 },
                    new DataVersion { Id = 10, Table = "ReviewRatings", Version = 0 }
                );
        }
        
        public static void SeedTables(this ModelBuilder modelBuilder)
        {
            var authorFaker = SeedAuthorTable();
            var authors = authorFaker.Generate(20);
            modelBuilder.Entity<Author>().HasData(authors);
            
            var categoryFaker = SeedCategoryTable();
            var categories = categoryFaker.Generate(20);
            modelBuilder.Entity<Category>().HasData(categories);

            var publisherFaker = SeedPublisherTable();
            var publishers = publisherFaker.Generate(20);
            modelBuilder.Entity<Publisher>().HasData(publishers);

            var bookFaker = SeedBookTable(publishers);
            var books = bookFaker.Generate(50);
            modelBuilder.Entity<Book>().HasData(books);
            
            var ratingFaker = SeedRatingTable(books);
            var ratings = ratingFaker.Generate(200);
            modelBuilder.Entity<Rating>().HasData(ratings);

            var authorCategoryFaker = SeedAuthorCategoryTable(authors, categories);
            var authorCategories = authorCategoryFaker.Generate(50)
                .GroupBy(ac => new { ac.AuthorId, ac.CategoryId })
                .Select(ac => ac.FirstOrDefault())
                .ToList();
            modelBuilder.Entity<AuthorCategory>().HasData(authorCategories!);

            var bookCategoryFaker = SeedBookCategoryTable(books, categories);
            var bookCategories = bookCategoryFaker.Generate(75)
                .GroupBy(bc => new { bc.BookId, bc.CategoryId })
                .Select(bc => bc.FirstOrDefault())
                .ToList();
            modelBuilder.Entity<BookCategory>().HasData(bookCategories!);
            
            var bookAuthorFaker = SeedBookAuthorTable(books, authors);
            var bookAuthors = bookAuthorFaker.Generate(75)
                .GroupBy(ba => new { ba.BookId, ba.AuthorId })
                .Select(ba => ba.FirstOrDefault())
                .ToList();
            modelBuilder.Entity<BookAuthor>().HasData(bookAuthors!);
        }

        private static Faker<Category> SeedCategoryTable()
        {
            return new Faker<Category>()
                .RuleFor(c => c.Id, f => f.IndexFaker + 1)
                .RuleFor(c => c.Name, f => f.Commerce.Department());
        }

        private static Faker<Publisher> SeedPublisherTable()
        {
            return new Faker<Publisher>()
                .RuleFor(p => p.Id, f => f.IndexFaker + 1)
                .RuleFor(p => p.Name, f => f.Company.CompanyName())
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
                .RuleFor(p => p.ImageUrl, f => f.Image.PicsumUrl(width: 350, height: 500));
        }

        private static Faker<Author> SeedAuthorTable()
        {
            return new Faker<Author>()
                .RuleFor(a => a.Id, f => f.IndexFaker + 1)
                .RuleFor(a => a.Name, f => f.Name.FullName())
                .RuleFor(a => a.Description, f => f.Commerce.ProductDescription())
                .RuleFor(a => a.ImageUrl, f => f.Image.PicsumUrl(width: 350, height: 500));
        }

        private static Faker<Book> SeedBookTable(List<Publisher> publishers)
        {
            return new Faker<Book>()
                .RuleFor(b => b.Id, f => f.IndexFaker + 1)
                .RuleFor(b => b.Title, f => f.Commerce.ProductName())
                .RuleFor(b => b.Description, f => f.Commerce.ProductDescription())
                .RuleFor(b => b.ImageUrl, f => f.Image.PicsumUrl(width: 350, height: 500))
                .RuleFor(b => b.ReleaseDate, f => f.Date.PastDateOnly())
                .RuleFor(b => b.Pages, f => f.Random.Number(100, 900))
                .RuleFor(b => b.Isbn, f => f.Random.Long(1000000000, 9999999999).ToString())
                .RuleFor(b => b.PublisherId, f => f.PickRandom(publishers).Id);
        }
        
        private static Faker<Rating> SeedRatingTable(List<Book> books)
        {
            return new Faker<Rating>()
                .RuleFor(r => r.Id, f => f.IndexFaker + 1)
                .RuleFor(r => r.Rate, f => f.Random.Int(1, 5))
                .RuleFor(r => r.BookId, f => f.PickRandom(books).Id);
        }
        
        private static Faker<AuthorCategory> SeedAuthorCategoryTable(List<Author> authors, List<Category> categories)
        {
            return new Faker<AuthorCategory>()
                .StrictMode(false)
                .UseSeed(1337)
                .RuleFor(ac => ac.Id, f => f.IndexFaker + 1)
                .RuleFor(ac => ac.AuthorId, f => f.PickRandom(authors).Id)
                .RuleFor(ac => ac.CategoryId, f => f.PickRandom(categories).Id);
        }

        private static Faker<BookCategory> SeedBookCategoryTable(List<Book> books, List<Category> categories)
        {
            return new Faker<BookCategory>()
                .StrictMode(false)
                .UseSeed(2115)
                .RuleFor(bc => bc.Id, f => f.IndexFaker + 1)
                .RuleFor(bc => bc.BookId, f => f.PickRandom(books).Id)
                .RuleFor(bc => bc.CategoryId, f => f.PickRandom(categories).Id);
        }
        
        private static Faker<BookAuthor> SeedBookAuthorTable(List<Book> books, List<Author> authors)
        {
            return new Faker<BookAuthor>()
                .StrictMode(false)
                .UseSeed(2137)
                .RuleFor(ba => ba.Id, f => f.IndexFaker + 1)
                .RuleFor(ba => ba.BookId, f => f.PickRandom(books).Id)
                .RuleFor(ba => ba.AuthorId, f => f.PickRandom(authors).Id);
        }
    }
}
