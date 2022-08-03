using System.ComponentModel.DataAnnotations;

namespace ASP.Net_Seminarski_rad.Models.Base
{
    public abstract class ProductCategoryBase
    {
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
