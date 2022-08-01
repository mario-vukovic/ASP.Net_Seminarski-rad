using ASP.Net_Seminarski_rad.Models.Base;
using ASP.Net_Seminarski_rad.Models.ViewModel;

namespace ASP.Net_Seminarski_rad.Models.Binding
{
    public class ProductUpdateBinding:ProductBase
    {
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategoryViewModel ProductCategory { get; set; }


    }
}
