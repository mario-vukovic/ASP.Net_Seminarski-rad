using System.ComponentModel.DataAnnotations;

namespace ASP.Net_Seminarski_rad.Models.Base
{
    public abstract class ProductBase
    {
        [Required]
        [StringLength(200, MinimumLength = 2)]
        [Display(Name = "Naziv")]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? ProductImgUrl { get; set; }

    }
}
