using ASP.Net_Seminarski_rad.Models;
using ASP.Net_Seminarski_rad.Services.Implementation;
using ASP.Net_Seminarski_rad.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Seminarski_rad.Controllers
{
    [Authorize(Roles = Roles.Admin)]
    public class AdminController : Controller
    {
        private readonly IProductService productService;
        private readonly IUserService userService;

        public AdminController(IProductService productService, IUserService userService)
        {
            this.productService = productService;
            this.userService = userService;
        }

        public IActionResult AdminPanel()
        {
            return View("AdminPanel");
        }

        public async Task<IActionResult> GetAllUsers()
        {
            var users = await userService.GetAllUsersAsync();
            return View(users);
        }
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await productService.GetAllProductsAsync();
            return View(products);
        }



    }
}
