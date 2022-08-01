using ASP.Net_Seminarski_rad.Models.Base;

namespace ASP.Net_Seminarski_rad.Models.Binding
{
    public class ProductCategoryBinding : ProductCategoryBase
    {

    }

    public class ProductCategoryUpdateBinding : ProductCategoryBinding
    {
        public int Id { get; set; }
    }
}
