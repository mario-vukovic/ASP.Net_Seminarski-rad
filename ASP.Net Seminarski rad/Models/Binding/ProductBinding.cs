using ASP.Net_Seminarski_rad.Models.Base;

namespace ASP.Net_Seminarski_rad.Models.Binding
{
    public class ProductBinding : ProductBase
    {
        public int ProductCategoryId { get; set; }
        public IFormFile ProductImg { get; set; }
    }
}
