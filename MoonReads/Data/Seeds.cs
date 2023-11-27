using Microsoft.AspNetCore.Identity;
using MoonReads.Dto;
using MoonReads.Models;

namespace MoonReads.Data
{
    public static class Seeds
    {
        public static async Task SeedRoles(WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var roles = new[] { "Admin", "Moderator", "User" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }
        }

        public static async Task SeedUsers(WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

            var usersSeed = new List<UserRegisterDto>
            {
                new()
                {
                    Email = "admin@moonreads.com",
                    UserName = "Admin",
                    FirstName = "Admin",
                    LastName = "Admin",
                    Password = "Admin1234!",
                    Role = "Admin"
                },
                new()
                {
                    Email = "moderator@moonreads.com",
                    UserName = "Moderator",
                    FirstName = "Moderator",
                    LastName = "Moderator",
                    Password = "Moderator1234!",
                    Role = "Moderator"
                },
                new()
                {
                    Email = "user@moonreads.com",
                    UserName = "User",
                    FirstName = "User",
                    LastName = "User",
                    Password = "User1234!",
                    Role = "User"
                }
            };

            foreach (var userSeed in usersSeed)
            {
                if (await userManager.FindByEmailAsync(userSeed.Email) != null) continue;
                var user = new User
                {
                    Email = userSeed.Email,
                    UserName = userSeed.UserName,
                    FirstName = userSeed.FirstName,
                    LastName = userSeed.LastName
                };

                await userManager.CreateAsync(user, userSeed.Password);

                await userManager.AddToRoleAsync(user, userSeed.Role);
            }
        }
    }
}