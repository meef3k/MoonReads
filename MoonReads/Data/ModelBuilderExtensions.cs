using Microsoft.EntityFrameworkCore;
using MoonReads.Models;

namespace MoonReads.Data;

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
                new DataVersion { Id = 9, Table = "Reviews", Version = 0 },
                new DataVersion { Id = 10, Table = "Reactions", Version = 0 },
                new DataVersion { Id = 11, Table = "Bookshelves", Version = 0 }
            );
    }
}