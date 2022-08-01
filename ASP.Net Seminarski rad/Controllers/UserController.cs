using ASP.Net_Seminarski_rad.Models;
using ASP.Net_Seminarski_rad.Models.Binding;
using ASP.Net_Seminarski_rad.Models.Dbo;
using ASP.Net_Seminarski_rad.Services.Implementation;
using ASP.Net_Seminarski_rad.Services.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Seminarski_rad.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userSevice;
        private readonly SignInManager<ApplicationUser> signInManager;

        public UserController(IUserService userSevice, SignInManager<ApplicationUser> signInManager)
        {
            this.userSevice = userSevice;
            this.signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(ApplicationUserBinding model)
        {
            var register = await userSevice.CreateUserAsync(model, Roles.BasicUser);
            if (true)
            {
                await signInManager.SignInAsync(register, true);
                return RedirectToAction("Index", "Home");
            }

        }

    }
}
