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

        public IdentityService(IServiceScopeFactory scopeFactory)
        {
            using var scope = scopeFactory.CreateScope();
            roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            //CreateRoleAsync(Admin).Wait();
            //CreateRoleAsync(Editor).Wait();
            //CreateRoleAsync(Employee).Wait();
            //CreateRoleAsync(BasicUser).Wait();

            //CreateUserAsync(new ApplicationUser
            //{
            //    Id = "1",
            //    Name = "Admin Test One",
            //    DateOfBirth = DateTime.Now.AddYears(-27),
            //    Email = "admin.test.one@gmail.com",
            //    EmailConfirmed = true,
            //    UserName = "Admin_test",
            //    PhoneNumber = "0958551636",
            //    PhoneNumberConfirmed = true,
            //    Active = true,
            //    Created = DateTime.Now,
            //    Address = new List<Address>
            //    {
            //        new() {City = "Osijek", CityPO = "31000", Street = "Vukovarska cesta", HouseNumber = "146", AddressType = Apartment},
            //        new() {City = "Babina Greda", CityPO = "32276", Street = "Kralja Tomislava", HouseNumber = "12", AddressType = House}
            //    },


            //}, "P1a2s3s4w5o6r7D8!!!", Admin).Wait();

            //CreateUserAsync(new ApplicationUser
            //{
            //    Id = "2",
            //    Name = "Employee Test One",
            //    DateOfBirth = DateTime.Now.AddYears(-22),
            //    Email = "employee.test.one@gmail.com",
            //    EmailConfirmed = true,
            //    UserName = "Employee_test",
            //    PhoneNumber = "0917521636",
            //    PhoneNumberConfirmed = true,
            //    Active = true,
            //    Created = DateTime.Now,
            //    Address = new List<Address>
            //    {
            //        new() {City = "Zagreb", CityPO = "10000", Street = "Zagrebacka cesta", HouseNumber = "52a", AddressType = Office},
            //        new() {City = "Velika Gorica", CityPO = "10001", Street = "Kralja Marka", HouseNumber = "7", AddressType = House}
            //    },


            //}, "Employee123!#", Employee).Wait();
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
