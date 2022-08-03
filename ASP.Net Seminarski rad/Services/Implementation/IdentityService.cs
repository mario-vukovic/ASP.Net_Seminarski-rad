using ASP.Net_Seminarski_rad.Data;
using ASP.Net_Seminarski_rad.Models.Binding;
using ASP.Net_Seminarski_rad.Models.Dbo;
using ASP.Net_Seminarski_rad.Models.ViewModel;
using ASP.Net_Seminarski_rad.Services.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using static ASP.Net_Seminarski_rad.Models.Roles;

namespace ASP.Net_Seminarski_rad.Services.Implementation
{
    public class IdentityService : IIdentityService
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext db;
        private readonly IProductService productService;
        private readonly IMapper mapper;
        public IdentityService(IServiceScopeFactory scopeFactory)
        {
            using var scope = scopeFactory.CreateScope();
            roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            CreateRoleAsync(Admin).Wait();
            CreateRoleAsync(Editor).Wait();
            CreateRoleAsync(Employee).Wait();
            CreateRoleAsync(BasicUser).Wait();

            //CreateUserAsync(new ApplicationUser
            //{
            //    FirstName = "Administrator",
            //    Email = "admin@admin.com",
            //    EmailConfirmed = true,
            //    UserName = "admin@admin.com",
            //}
            //    , "Admin123!", Admin).Wait();

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
                throw new Exception("User with that email already exists");
            }

            var createNewUser = await userManager.CreateAsync(applicationUser, password);
            if (createNewUser.Succeeded)
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
