using ASP.Net_Seminarski_rad.Models;
using ASP.Net_Seminarski_rad.Models.Binding;
using ASP.Net_Seminarski_rad.Models.Dbo;
using ASP.Net_Seminarski_rad.Services.Implementation;
using ASP.Net_Seminarski_rad.Services.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using SendGrid.Helpers.Mail.Model;

namespace ASP.Net_Seminarski_rad.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IMapper mapper;


        public UserController(IUserService userSevice, SignInManager<ApplicationUser> signInManager, IMapper mapper)
        {
            this.userService = userSevice;
            this.signInManager = signInManager;
            this.mapper = mapper;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(ApplicationUserBinding model)
        {
            var register = await userService.CreateUserAsync(model, Roles.BasicUser);
            if (true)
            {
                await signInManager.SignInAsync(register, false);
                return RedirectToAction("Index", "Home");
            }

        }
        //=================================================================================================
        public async Task<IActionResult> UserManagament()
        {
            var users = await userService.GetAllUsersAsync();
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(ApplicationUserBinding model, string role)
        {
            await userService.CreateNewUserAsync(model, role);
            return RedirectToAction("UserManagament");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateUser(string id)
        {
            var user = await userService.GetUserAsync(id);
            var model = mapper.Map<ApplicationUserBinding>(user);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(ApplicationUserBinding model)
        {
            var user = await userService.UpdateUserAsync(model);
            return RedirectToAction("UserManagament");
        }

        //[HttpGet]
        //public async Task<IActionResult> DeleteUser(string id)
        //{
        //    var user = userService.GetUserAsync(id);
        //    return View(user);
        //}

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userService.GetUserAsync(id);
            if (user != null)
            {
                await userService.DeleteUserAsync(id);
            }
            return RedirectToAction("UserManagament");
        }




    }

}

