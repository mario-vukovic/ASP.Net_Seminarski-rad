using ASP.Net_Seminarski_rad.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ASP.Net_Seminarski_rad.Data;
using ASP.Net_Seminarski_rad.Models.ViewModel;
using ASP.Net_Seminarski_rad.Services.Implementation;

namespace ASP.Net_Seminarski_rad.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;

        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View(productService.GetProductsAsync().Result);
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await productService.GetProductAsync(id);
            return View(product);
        }
        
        public IActionResult Categories()
        {
            return View(productService.GetAllProductCategoriesAsync().Result);
        }

        public async Task<IActionResult> CategoryDetails(int id)
        {
            ViewBag.ProductCategoryId = id;
            var model = new CreateProductViewModel
            {
                Products = await productService.GetCategoryProductsAsync(id),
                ProductToCategoryId = id
            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}