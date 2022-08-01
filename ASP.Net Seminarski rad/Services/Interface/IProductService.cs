using ASP.Net_Seminarski_rad.Models.ViewModel;

namespace ASP.Net_Seminarski_rad.Services.Interface;

public interface IProductService
{
    Task<List<ProductViewModel>> GetAllProductsAsync();
}