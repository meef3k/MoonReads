using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoonReads.Models;

namespace MoonReads.Data
{
	public class DataContext : IdentityDbContext<User>
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}

        public required DbSet<Author> Authors { get; set; }
        public required DbSet<Book> Books { get; set; }
        public required DbSet<Category> Categories { get; set; }
        public required DbSet<Publisher> Publishers { get; set; }
        public required DbSet<AuthorCategory> AuthorCategories { get; set; }
        public required DbSet<BookAuthor> BookAuthors { get; set; }
        public required DbSet<BookCategory> BookCategories { get; set; }
        public required DbSet<Rating> Ratings { get; set; }
        public required DbSet<DataVersion> DataVersions { get; set; }
        public required DbSet<Review> Reviews { get; set; }
        public required DbSet<Reaction> Reactions { get; set; }
        public required DbSet<Bookshelf> Bookshelves { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<AuthorCategory>()
                .HasKey(ac => new { ac.AuthorId, ac.CategoryId });
            modelBuilder.Entity<AuthorCategory>()
                .HasOne(a => a.Author)
                .WithMany(ac => ac.AuthorCategories)
                .HasForeignKey(a => a.AuthorId);
            modelBuilder.Entity<AuthorCategory>()
                .HasOne(c => c.Category)
                .WithMany(ac => ac.AuthorCategories)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<BookCategory>()
                .HasKey(bc => new { bc.BookId, bc.CategoryId });
            modelBuilder.Entity<BookCategory>()
                .HasOne(b => b.Book)
                .WithMany(bc => bc.BookCategories)
                .HasForeignKey(b => b.BookId);
            modelBuilder.Entity<BookCategory>()
                .HasOne(c => c.Category)
                .WithMany(bc => bc.BookCategories)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<BookAuthor>()
                .HasKey(ba => new { ba.BookId, ba.AuthorId });
            modelBuilder.Entity<BookAuthor>()
                .HasOne(b => b.Book)
                .WithMany(ba => ba.BookAuthors)
                .HasForeignKey(b => b.BookId);
            modelBuilder.Entity<BookAuthor>()
                .HasOne(a => a.Author)
                .WithMany(ba => ba.BookAuthors)
                .HasForeignKey(a => a.AuthorId);

            modelBuilder.Entity<Rating>()
                .Property(r => r.ReviewId)
                .IsRequired(false);
            
            modelBuilder.SeedDataVersionTable();
        }
    }
}
