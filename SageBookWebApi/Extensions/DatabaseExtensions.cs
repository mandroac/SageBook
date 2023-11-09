using DataAccess;
using Domain.Constants;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SageBookWebApi.Extensions
{
    public static class DatabaseExtensions
    {
        public static async Task MigrateDatabaseAsync(this WebApplication webApp)
        {
            if (EF.IsDesignTime)
            {
                return;
            }
            else
            {
                using var scope = webApp.Services.CreateScope();
                var dbContext = scope.ServiceProvider.GetRequiredService<SageBookDbContext>();
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<AppRole>>();

                await dbContext.Database.MigrateAsync();
                await roleManager.SeedAppRolesAsync();
                await userManager.SeedAppAdminAsync();
            }
        }

        private static async Task SeedAppRolesAsync(this RoleManager<AppRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync(AppRoles.Admin))
            {
                await roleManager.CreateAsync(new AppRole
                {
                    Name = AppRoles.Admin
                });
            }

            if (!await roleManager.RoleExistsAsync(AppRoles.User))
            {
                await roleManager.CreateAsync(new AppRole
                {
                    Name = AppRoles.User
                });
            }
        }

        private static async Task SeedAppAdminAsync(this UserManager<AppUser> userManager)
        {
            if (!await userManager.Users.AnyAsync())
            {
                var user = new AppUser
                {
                    Email = "admin@email.com",
                    EmailConfirmed = true,
                    UserName = "admin@email.com"
                };

                await userManager.CreateAsync(user, "admin");
                await userManager.AddToRoleAsync(user, AppRoles.Admin);
            }
        }
    }
}
