using ASP.Net_Seminarski_rad.Data;
using ASP.Net_Seminarski_rad.Models;
using ASP.Net_Seminarski_rad.Models.Binding;
using ASP.Net_Seminarski_rad.Models.Dbo;
using ASP.Net_Seminarski_rad.Models.ViewModel;
using ASP.Net_Seminarski_rad.Services.Implementation;
using ASP.Net_Seminarski_rad.Services.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_Seminarski_rad.Controllers
{
    [Authorize(Roles = Roles.Admin)]
    public class AdminController : Controller
    {
        private readonly IProductService productService;
        private readonly IMapper mapper;
        public AdminController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }

        public IActionResult AdminPanel()
        {
            return View("AdminPanel");
        }

        public async Task<IActionResult> ProductManagament()
        {
            var products = await productService.GetProductsAsync();
            return View(products);
        }

        public async Task<IActionResult> CreateProduct(int id)
        {
            return View(new ProductBinding { ProductCategoryId = id });
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductBinding model)
        {
            var product = await productService.CreateProductAsync(model);
            return RedirectToAction("ProductManagament", new { id = product.ProductCategory.Id });
        }

        public async Task<IActionResult> ProductDetails(int id)
        {
            var product = await productService.GetProductAsync(id);
            return View(product);
        }

        public async Task<IActionResult> UpdateProduct(int id)
        {
            var product = await productService.GetProductAsync(id);
            var model = mapper.Map<ProductUpdateBinding>(product);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(ProductUpdateBinding model)
        {
            var product = await productService.UpdateProductAsync(model);
            return RedirectToAction("ProductManagament");
        }
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await productService.GetProductAsync(id);
            var model = mapper.Map<Product>(product);
            return View(model);
        }

        [HttpPost, ActionName("DeleteProduct")]
        public async Task<IActionResult> DeleteProductConfirmed(int id)
        {
            var product = await productService.GetProductAsync(id);
            var model = mapper.Map<Product>(product);

            await productService.DeleteProductAsync(model);

            return RedirectToAction("ProductManagament");
        }

        public async Task<IActionResult> ProductCategoryManagament()
        {
            var products = await productService.GetAllProductCategoriesAsync();
            return View(products);
        }

        public async Task<IActionResult> CreateProductCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductCategory(ProductCategoryBinding model)
        {
            await productService.CreateProductCategoryAsync(model);
            return RedirectToAction("ProductCategoryManagament");
        }

        public async Task<IActionResult> ProductCategoryDetails(int id)
        {
            ViewBag.ProductCategoryId = id;
            var model = new CreateProductViewModel
            {
                Products = await productService.GetCategoryProductsAsync(id),
                ProductToCategoryId = id
            };
            return View(model);
        }

        public async Task<IActionResult> UpdateProductCategory(int id)
        {
            var productCategory = await productService.GetProductCategoryAsync(id);
            var model = mapper.Map<ProductCategoryUpdateBinding>(productCategory);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProductCategory(ProductCategoryUpdateBinding model)
        {
            var productCategory = await productService.UpdateProductCategoryAsync(model);
            return RedirectToAction("ProductCategoryManagament");
        }

        public async Task<IActionResult> DeleteProductCategory(int id)
        {
            var product = await productService.GetProductCategoryAsync(id);
            var model = mapper.Map<ProductCategory>(product);
            return View(model);
        }

        [HttpPost, ActionName("DeleteProductCategory")]
        public async Task<IActionResult> DeleteProductCategoryConfirmed(int id)
        {
            var product = await productService.GetProductCategoryAsync(id);
            var model = mapper.Map<ProductCategory>(product);

            await productService.DeleteProductCategoryAsync(model);

            return RedirectToAction("ProductCategoryManagament");
        }
    }
}
