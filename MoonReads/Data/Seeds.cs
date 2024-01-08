using Bogus;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MoonReads.Dto;
using MoonReads.Helper;
using MoonReads.Models;

namespace MoonReads.Data;

public static class Seeds
{
    private const int DefaultSeed = 2115;

    public static async Task SeedDataAsync(WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<DataContext>();
        var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

        await SeedRolesAsync(scope);
        await SeedUsersAsync(context, scope, logger, 1000);
        await SeedHeadUsersAsync(scope);
        await SeedCategoriesAsync(context, logger, 20);
        await SeedAuthorsAsync(context, logger, 1000);
        await SeedPublishersAsync(context, logger, 100);
        await SeedBooksAsync(context, logger, 10000);
        await SeedRatingsAsync(context, logger, 25);
        await SeedReactionsAsync(context, logger, 50);
        await SeedBookshelvesAsync(context, logger, 25);
    }
    
    private static async Task SeedRolesAsync(IServiceScope scope)
    {
        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var roles = new[] { UserRoles.Admin, UserRoles.Moderator, UserRoles.User };

        foreach (var role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
                await roleManager.CreateAsync(new IdentityRole(role));
        }
    }

    private static async Task SeedHeadUsersAsync(IServiceScope scope)
    {
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

        var usersSeed = new List<UserRegisterDto>
        {
            new()
            {
                Email = "Admin@moonreads.com",
                UserName = "Admin",
                Password = "Admin1234!"
            },
            new()
            {
                Email = "Aoderator@moonreads.com",
                UserName = "Moderator",
                Password = "Moderator1234!"
            }
        };

        foreach (var userSeed in usersSeed)
        {
            if (await userManager.FindByEmailAsync(userSeed.Email) != null) continue;
            var user = new User
            {
                Email = userSeed.Email,
                UserName = userSeed.UserName,
                Description = Defaults.UserDescription,
                Avatar = Defaults.UserPhoto
            };

            await userManager.CreateAsync(user, userSeed.Password);

            switch (userSeed.UserName)
            {
                case UserRoles.Admin:
                    await userManager.AddToRoleAsync(user, UserRoles.Admin);
                    break;
                case UserRoles.Moderator:
                    await userManager.AddToRoleAsync(user, UserRoles.Moderator);
                    break;
            }
        }
    }
    
    private static async Task SeedUsersAsync(DataContext context, IServiceScope scope, ILogger logger, int amount)
    {
        if (!context.Users.Any())
        {
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

            for (var i = 1; i <= amount; i++)
            {
                var username = $"User{i}";

                var user = new User
                {
                    UserName = username,
                    Email = $"{username}@moonreads.com",
                    Description = Defaults.UserDescription,
                    Avatar = Defaults.UserPhoto
                };

                var result = await userManager.CreateAsync(user, "User1234!");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, UserRoles.User);
                }
            }

            logger.LogInformation("Seeded Users.");
        }
        else
        {
            logger.LogInformation("Users already seeded.");
        }
    }
    
    private static async Task SeedCategoriesAsync(DataContext context, ILogger logger, int amount)
    {
        if (!context.Categories.Any())
        {
            var categoryFaker = new Faker<Category>()
                .UseSeed(DefaultSeed)
                .RuleFor(c => c.Name, f => f.Commerce.Categories(1)[0]);

            var categories = categoryFaker.Generate(amount);

            context.Categories.AddRange(categories);
            await context.SaveChangesAsync();

            logger.LogInformation("Seeded Categories.");
        }
        else
        {
            logger.LogInformation("Categories already seeded.");
        }
    }
    
    private static async Task SeedAuthorsAsync(DataContext context, ILogger logger, int amount)
    {
        if (!context.Authors.Any())
        {
            var authorFaker = new Faker<Author>()
                .UseSeed(DefaultSeed)
                .RuleFor(a => a.Name, f => f.Name.FullName())
                .RuleFor(a => a.Description, f => f.Commerce.ProductDescription())
                .RuleFor(a => a.ImageUrl, f => f.Image.PicsumUrl(width: 350, height: 500));

            var authors = authorFaker.Generate(amount);
            var existingCategories = await context.Categories.ToListAsync();

            foreach (var author in authors)
            {
                var categoryIds = existingCategories.OrderBy(_ => new Random().Next()).Take(2).Select(c => c.Id).ToList();
                
                author.AuthorCategories = categoryIds.Select(categoryId => new AuthorCategory { CategoryId = categoryId }).ToList();
            }

            context.Authors.AddRange(authors);
            await context.SaveChangesAsync();

            logger.LogInformation("Seeded Authors.");
        }
        else
        {
            logger.LogInformation("Authors already seeded.");
        }
    }

    private static async Task SeedPublishersAsync(DataContext context, ILogger logger, int amount)
    {
        if (!context.Publishers.Any())
        {
            var publisherFaker = new Faker<Publisher>()
                .UseSeed(DefaultSeed)
                .RuleFor(p => p.Name, f => f.Company.CompanyName())
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
                .RuleFor(p => p.ImageUrl, f => f.Image.PicsumUrl(width: 350, height: 500));

            var publishers = publisherFaker.Generate(amount);

            context.Publishers.AddRange(publishers);
            await context.SaveChangesAsync();

            logger.LogInformation("Seeded Publishers.");
        }
        else
        {
            logger.LogInformation("Publishers already seeded.");
        }
    }
    
    private static async Task SeedBooksAsync(DataContext context, ILogger logger, int amount)
    {
        if (!context.Books.Any())
        {
            var publishers = context.Publishers.Select(p => p.Id).ToList();
            
            var bookFaker = new Faker<Book>()
                .UseSeed(DefaultSeed)
                .RuleFor(b => b.Title, f => f.Commerce.ProductName())
                .RuleFor(b => b.Description, f => f.Commerce.ProductDescription())
                .RuleFor(b => b.ImageUrl, f => f.Image.PicsumUrl(width: 350, height: 500))
                .RuleFor(b => b.ReleaseDate, f => f.Date.BetweenDateOnly(DateOnly.FromDateTime(DateTime.Now.AddYears(-50)), DateOnly.FromDateTime(DateTime.Now.AddYears(1))))
                .RuleFor(b => b.Pages, f => f.Random.Number(100, 900))
                .RuleFor(b => b.Isbn, f => f.Random.Long(1000000000, 9999999999).ToString())
                .RuleFor(b => b.PublisherId, f => f.PickRandom(publishers));
            
            var existingAuthors = await context.Authors.ToListAsync();
            var existingCategories = await context.Categories.ToListAsync();

            var books = bookFaker.Generate(amount);

            foreach (var book in books)
            {
                var random = new Random();
                
                var randomChance = random.Next(1, 11);

                var authorIds = new List<int>();
                var categoryIds = new List<int>();
                
                if (randomChance <= 9)
                {
                    var singleAuthor = existingAuthors.OrderBy(_ => random.Next()).First();
                    var singleCategory = existingCategories.OrderBy(_ => random.Next()).First();
                    authorIds.Add(singleAuthor.Id);
                    categoryIds.Add(singleCategory.Id);
                    book.BookAuthors = authorIds.Select(authorId => new BookAuthor { AuthorId = authorId }).ToList();
                    book.BookCategories = categoryIds.Select(categoryId => new BookCategory { CategoryId = categoryId }).ToList();
                }
                else
                {
                    var twoAuthors = existingAuthors.OrderBy(_ => random.Next()).Take(2).ToList();
                    var twoCategories = existingCategories.OrderBy(_ => random.Next()).Take(2).ToList();
                    authorIds.AddRange(twoAuthors.Select(a => a.Id));
                    categoryIds.AddRange(twoCategories.Select(a => a.Id));
                    book.BookAuthors = authorIds.Select(authorId => new BookAuthor { AuthorId = authorId }).ToList();
                    book.BookCategories = categoryIds.Select(categoryId => new BookCategory { CategoryId = categoryId }).ToList();
                }
            }

            context.Books.AddRange(books);
            await context.SaveChangesAsync();

            logger.LogInformation("Seeded Books.");
        }
        else
        {
            logger.LogInformation("Books already seeded.");
        }
    }

    private static async Task SeedRatingsAsync(DataContext context, ILogger logger, int userAmount)
    {
        if (!context.Ratings.Any())
        {
            var users = await context.Users.ToListAsync();
            var books = context.Books.Select(p => p.Id).ToList();

            var random = new Random();
            var reviewFaker = new Faker<Review>()
                .UseSeed(DefaultSeed)
                .RuleFor(r => r.Title, f => f.Lorem.Sentence())
                .RuleFor(r => r.Description, f => f.Lorem.Paragraph())
                .RuleFor(r => r.CreationDateTime, f => f.Date.Past().ToUniversalTime())
                .RuleFor(r => r.Reported, f => f.Random.Bool(0.05f));

            var ratingFaker = new Faker<Rating>()
                .UseSeed(DefaultSeed)
                .RuleFor(r => r.Rate, f => f.Random.Number(1, 5))
                .RuleFor(r => r.BookId, f => f.PickRandom(books));

            foreach (var user in users)
            {
                var ratings = ratingFaker.Generate(userAmount);

                foreach (var rating in ratings)
                {
                    rating.UserId = user.Id;

                    if (random.Next(0, 5) != 1) continue;
                    var review = reviewFaker.Generate();

                    rating.Review = review;
                }
                
                context.Ratings.AddRange(ratings);
            }

            await context.SaveChangesAsync();

            logger.LogInformation("Seeded Ratings.");
        }
        else
        {
            logger.LogInformation("Ratings already seeded.");
        }
    }
    
    private static async Task SeedReactionsAsync(DataContext context, ILogger logger, int userAmount)
    {
        if (!context.Reactions.Any())
        {
            var reviews = context.Reviews.Select(p => p.Id).ToList();
            var users = await context.Users.ToListAsync();
            
            var reactionFaker = new Faker<Reaction>()
                .UseSeed(DefaultSeed)
                .RuleFor(r => r.Like, f => f.Random.Bool())
                .RuleFor(r => r.ReviewId, f => f.PickRandom(reviews));
            
            foreach (var user in users)
            {
                var reactions = reactionFaker.Generate(userAmount);
                
                foreach (var reaction in reactions)
                {
                    reaction.UserId = user.Id;
                }
                    
                context.Reactions.AddRange(reactions);
            }

            await context.SaveChangesAsync();

            logger.LogInformation("Seeded Reactions.");
        }
        else
        {
            logger.LogInformation("Reactions already seeded.");
        }
    }
    
    private static async Task SeedBookshelvesAsync(DataContext context, ILogger logger, int userAmount)
    {
        if (!context.Bookshelves.Any())
        {
            var users = await context.Users.ToListAsync();
            var books = context.Books.Select(p => p.Id).ToList();
            
            var bookshelfFaker = new Faker<Bookshelf>()
                .UseSeed(DefaultSeed)
                .RuleFor(b => b.Status, f => f.PickRandom(Statuses.ToRead, Statuses.Reading, Statuses.Read))
                .RuleFor(b => b.BookId, f => f.PickRandom(books));

            foreach (var user in users)
            {
                var bookshelves = bookshelfFaker.Generate(userAmount);

                foreach (var bookshelf in bookshelves)
                {
                    bookshelf.UserId = user.Id;
                }
                
                context.Bookshelves.AddRange(bookshelves);
            }

            await context.SaveChangesAsync();

            logger.LogInformation("Seeded Bookshelves.");
        }
        else
        {
            logger.LogInformation("Bookshelves already seeded.");
        }
    }
}