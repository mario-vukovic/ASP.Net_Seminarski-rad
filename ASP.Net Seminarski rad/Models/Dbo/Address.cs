using System.ComponentModel.DataAnnotations;

namespace ASP.Net_Seminarski_rad.Models.Dbo
{
    public class Address
    {
        [Key]
        //public string Country { get; set; }
        public string City { get; set; }
        public string CityPO { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public AddressTypeEnum AddressType { get; set; }
    }
}
