using ASP.Net_Seminarski_rad.Data;
using ASP.Net_Seminarski_rad.Models;
using ASP.Net_Seminarski_rad.Models.Dbo;
using ASP.Net_Seminarski_rad.Services.Interface;
using Microsoft.AspNetCore.Identity;
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
            CreateRoleAsync(Editor).Wait();
            CreateRoleAsync(Employee).Wait();
            CreateRoleAsync(BasicUser).Wait();

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

            //CreateUserAsync(new ApplicationUser
            //{
            //    Id = "2",
            //    Name = "Editor1",
            //    DateOfBirth = DateTime.Now.AddYears(-22),
            //    Email = "editor1@shop.com",
            //    EmailConfirmed = true,
            //    UserName = "editor1@shop.com",
            //    Active = true,
            //    Created = DateTime.Now,
            //    Address = new List<Address>
            //    {
            //        new() {City = "Osijek", CityPO = "31000", Street = "Vukovarska cesta", HouseNumber = "146", AddressType = Apartment},
            //    }}
            //    , "Employee123!", Editor).Wait();

            //CreateUserAsync(new ApplicationUser
            //{
            //    Id = "3",
            //    Name = "Employee1",
            //    DateOfBirth = DateTime.Now.AddYears(-22),
            //    Email = "employee1@shop.com",
            //    EmailConfirmed = true,
            //    UserName = "employee1@shop.com",
            //    Active = true,
            //    Created = DateTime.Now,
            //    Address = new List<Address>
            //    {
            //        new() {City = "Zagreb", CityPO = "10000", Street = "Zagrebacka cesta", HouseNumber = "52a", AddressType = Office},
            //    }}
            //    , "Employee123!", Employee).Wait();


            //CreateUserAsync(new ApplicationUser
            //{
            //    Id = "4",
            //    Name = "BasicUser1",
            //    DateOfBirth = DateTime.Now.AddYears(-27),
            //    Email = "basicuser1@shop.com",
            //    EmailConfirmed = true,
            //    UserName = "basicuser1@shop.com",
            //    Active = true,
            //    Created = DateTime.Now,
            //    Address = new List<Address>
            //    {
            //        new() {City = "Babina Greda", CityPO = "32276", Street = "Kralja Tomislava", HouseNumber = "12", AddressType = House}
            //    }}
            //    , "BasicUser123!", BasicUser).Wait();
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
