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
                    Password = "Admin1234!"
                },
                new()
                {
                    Email = "moderator@moonreads.com",
                    UserName = "Moderator",
                    Password = "Moderator1234!"
                },
                new()
                {
                    Email = "user@moonreads.com",
                    UserName = "User",
                    Password = "User1234!"
                }
            };

            foreach (var userSeed in usersSeed)
            {
                if (await userManager.FindByEmailAsync(userSeed.Email) != null) continue;
                var user = new User
                {
                    Email = userSeed.Email,
                    UserName = userSeed.UserName,
                };

                await userManager.CreateAsync(user, userSeed.Password);

                switch (userSeed.UserName)
                {
                    case "Admin":
                        await userManager.AddToRoleAsync(user, "Admin");
                        break;
                    case "Moderator":
                        await userManager.AddToRoleAsync(user, "Moderator");
                        break;
                    case "User":
                        await userManager.AddToRoleAsync(user, "User");
                        break;
                }
            }
        }
    }
}