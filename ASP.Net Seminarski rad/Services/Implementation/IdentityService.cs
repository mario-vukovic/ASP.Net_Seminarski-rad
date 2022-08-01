using ASP.Net_Seminarski_rad.Data;
using ASP.Net_Seminarski_rad.Models;
using ASP.Net_Seminarski_rad.Models.Dbo;
using ASP.Net_Seminarski_rad.Services.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static ASP.Net_Seminarski_rad.Models.RolesEnum;
using static ASP.Net_Seminarski_rad.Models.AddressTypeEnum;

namespace ASP.Net_Seminarski_rad.Services.Implementation
{
    public class IdentityService : IIdentityService
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext db;
        public IdentityService(IServiceScopeFactory scopeFactory)
        {
            using var scope = scopeFactory.CreateScope();
            roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            CreateRoleAsync(Admin).Wait();

            //CreateUserAsync(new ApplicationUser
            //{
            //    Id = "1",
            //    Name = "Administrator",
            //    DateOfBirth = DateTime.Now.AddYears(-27),
            //    Email = "admin@admin.com",
            //    EmailConfirmed = true,
            //    UserName = "admin@admin.com",
            //    Active = true,
            //    Created = DateTime.Now, }
            //    , "Admin123!", Admin).Wait();


        }


        public async Task CreateRoleAsync(string role)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole { Name = role });
            }
        }

        //public async Task GetAllUsersAsync()
        //{
        //    var dbo = await db.ApplicationUser.ToListAsync();
        //}

        //public async Task GetUserByEmailAync(string email)
        //{
        //    var dbo = await db.ApplicationUser.FirstOrDefaultAsync(x => x.Email == email);
        //}

        //public async Task UpdateUserAsync(string email, ApplicationUser appUser)
        //{
        //    var dbo = await db.ApplicationUser.FirstOrDefaultAsync(x => x.Email == email);
        //    dbo.FirstName = appUser.FirstName;
        //    dbo.LastName = appUser.LastName;
        //    dbo.Address = appUser.Address;
        //    dbo.Dob = appUser.Dob;
        //    dbo.Email = appUser.Email;
        //    dbo.EmailConfirmed = appUser.EmailConfirmed;
        //    dbo.UserName = appUser.UserName;

        //}

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

        public async Task DeleteUserAsync(ApplicationUser applicationUser)
        {
            var findUserById = await roleManager.FindByIdAsync(applicationUser.Id);
            if (findUserById != null)
            {
                await userManager.DeleteAsync(applicationUser);
            }
        }

    }
}
