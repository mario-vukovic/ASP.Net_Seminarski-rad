using System.ComponentModel.DataAnnotations;
using ASP.Net_Seminarski_rad.Models.Base;
using ASP.Net_Seminarski_rad.Models.Dbo.Base;

namespace ASP.Net_Seminarski_rad.Models.Dbo
{
    public class Address : AddressBase, IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}
