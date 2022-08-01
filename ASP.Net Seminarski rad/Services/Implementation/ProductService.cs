using ASP.Net_Seminarski_rad.Data;
using ASP.Net_Seminarski_rad.Models.ViewModel;
using ASP.Net_Seminarski_rad.Services.Interface;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_Seminarski_rad.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IMapper mapper;
        private readonly ApplicationDbContext db;

        public ProductService(IMapper mapper, ApplicationDbContext db)
        {
            this.mapper = mapper;
            this.db = db;
        }

        public async Task<List<ProductViewModel>> GetAllProductsAsync()
        {
            var products = await db.Product.ToListAsync();
            return products.Select(x=>mapper.Map<ProductViewModel>(x)).ToList();
        }
    }
}
