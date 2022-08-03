using ASP.Net_Seminarski_rad.Models.Base;

namespace ASP.Net_Seminarski_rad.Models.ViewModel
{
    public class ProductViewModel : ProductBase
    {
        public int Id { get; set; }
        public ProductCategoryViewModel ProductCategory { get; set; }
    }
}
