using ASP.Net_Seminarski_rad.Models.Base;
using ASP.Net_Seminarski_rad.Models.Dbo.Base;

namespace ASP.Net_Seminarski_rad.Models.Dbo
{
    public class Product : ProductBase, IEntityBase
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public ProductCategory ProductCategory { get; set; }

    }
}
