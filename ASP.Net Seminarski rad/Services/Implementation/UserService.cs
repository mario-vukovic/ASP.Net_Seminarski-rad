using ASP.Net_Seminarski_rad.Data;
using ASP.Net_Seminarski_rad.Models.Binding;
using ASP.Net_Seminarski_rad.Models.Dbo;
using ASP.Net_Seminarski_rad.Models.ViewModel;
using ASP.Net_Seminarski_rad.Services.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_Seminarski_rad.Services.Implementation
{
    public class UserService : IUserService
    {

        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IMapper mapper;
        private SignInManager<ApplicationUser> signInManager;
        private readonly ApplicationDbContext db;

        public UserService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.mapper = mapper;
            this.signInManager = signInManager;
            this.db = db;
        }

        public async Task<ApplicationUser> CreateUserAsync(ApplicationUserBinding model, string role)
        {
            var findUserByEmail = await userManager.FindByEmailAsync(model.Email);
            if (findUserByEmail != null)
            {
                throw new Exception("User with that email already exists");
            }

            var user = mapper.Map<ApplicationUser>(model);
            var address = mapper.Map<Address>(model.UserAddress);
            user.Address = new List<Address>() { address };

            var createUser = await userManager.CreateAsync(user, model.Password);
            if (createUser.Succeeded)
            {

                var assignRole = await userManager.AddToRoleAsync(user, role);
                if (!assignRole.Succeeded)
                {
                    throw new Exception("Role assignment failed!");
                }

            }
            return user;

        }

        public async Task<ApplicationUser> CreateNewUserAsync(ApplicationUserBinding model, string role)
        {
            var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
            var password = model.Password;
            var createUser = await userManager.CreateAsync(user, password);
            if (createUser.Succeeded)
            {
                var assignRole = await userManager.AddToRoleAsync(user, role);
                if (!assignRole.Succeeded)
                {
                    throw new Exception("Role assignment failed!");
                }

            }
            db.ApplicationUser.Add(user);
            await db.SaveChangesAsync();
            return (user);
        }

        public async Task<List<ApplicationUserViewModel>> GetAllUsersAsync()
        {
            var users = await db.ApplicationUser.Include(x => x.Address).ToListAsync();
            return users.Select(x => mapper.Map<ApplicationUserViewModel>(x)).ToList();
        }

        public async Task<ApplicationUserViewModel> GetUserAsync(string id)
        {
            var user = await db.ApplicationUser.FirstOrDefaultAsync(x => x.Id == id);
            return mapper.Map<ApplicationUserViewModel>(user);
        }

        public async Task<ApplicationUserViewModel> DeleteUserAsync(string id)
        {
            var user = await db.ApplicationUser.FirstOrDefaultAsync(x => x.Id == id);
            if (user != null)
            {
                db.ApplicationUser.Remove(user);
            }
            await db.SaveChangesAsync();
            return mapper.Map<ApplicationUserViewModel>(user);
        }

        public async Task<ApplicationUserViewModel> UpdateUserAsync(ApplicationUserBinding model)
        {
            var user = await db.ApplicationUser.FindAsync(model);
            mapper.Map(model, user);
            await db.SaveChangesAsync();
            return mapper.Map<ApplicationUserViewModel>(user);
        }

    }
}
