using ASP.Net_Seminarski_rad.Models.Binding;
using ASP.Net_Seminarski_rad.Models.Dbo;
using ASP.Net_Seminarski_rad.Models.ViewModel;

namespace ASP.Net_Seminarski_rad.Services.Implementation;

public interface IProductService
{
    Task<List<ProductViewModel>> GetCategoryProductsAsync(int productCategoryId);
    Task<ProductViewModel> GetProductAsync(int id);
    Task<ProductViewModel> CreateProductAsync(ProductBinding model);
    Task<ProductViewModel> UpdateProductAsync(ProductUpdateBinding model);
    Task DeleteProductAsync(Product model);
    Task<ProductCategoryViewModel> GetProductCategoryAsync(int id);
    Task<List<ProductCategoryViewModel>> GetAllProductCategoriesAsync();
    Task<ProductCategoryViewModel> CreateProductCategoryAsync(ProductCategoryBinding model);
    Task<ProductCategoryViewModel> UpdateProductCategoryAsync(ProductCategoryUpdateBinding model);
    Task DeleteProductCategoryAsync(ProductCategory model);
    Task<List<ProductViewModel>> GetProductsAsync();
}