using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASP.Net_Seminarski_rad.Models.Base;
using ASP.Net_Seminarski_rad.Models.Dbo.Base;

namespace ASP.Net_Seminarski_rad.Models.Dbo
{
    public class ProductCategory : ProductCategoryBase, IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }

        [ForeignKey("ProductCategory")]
        public int ProductId { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
