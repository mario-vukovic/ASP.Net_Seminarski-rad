using ASP.Net_Seminarski_rad.Models.Dbo;
using ASP.Net_Seminarski_rad.Services.Interface;
using Microsoft.AspNetCore.Identity;
using static ASP.Net_Seminarski_rad.Models.RolesEnum;

namespace ASP.Net_Seminarski_rad.Services.Implementation
{
    public class IdentityService : IIdentityService
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public IdentityService(IServiceScopeFactory scopeFactory)
        {
            using var scope = scopeFactory.CreateScope();
            roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            CreateRoleAsync(Admin).Wait();
            CreateRoleAsync(Editor).Wait();
            CreateRoleAsync(Employee).Wait();
            CreateRoleAsync(BasicUser).Wait();

            CreateUserAsync(new ApplicationUser
            {
                Name = "Admin Test One",
                DateOfBirth = DateTime.Now.AddYears(-27),
                Email = "admin.test.one@gmail.com",
                EmailConfirmed = true,
                Active = true,
                Created = DateTime.Now
            }
                , "p1a2s3s4w5o6r7d8", Admin).Wait();

        }

        public async Task CreateRoleAsync(string role)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole { Name = role });
            }
        }

        public async Task CreateUserAsync(ApplicationUser applicationUser, string password, string role)
        {
            var findUserByEmail = await userManager.FindByEmailAsync(applicationUser.Email);
            if (findUserByEmail != null)
            {
                return;
            }

            applicationUser.EmailConfirmed = true;

            var newUser = await userManager.CreateAsync(applicationUser);
            if (newUser.Succeeded)
            {
                var assignRole = await userManager.AddToRoleAsync(applicationUser, role);
                if (!assignRole.Succeeded)
                {
                    throw new Exception("Role assignment failed!");
                }
            }
        }
    }
}
