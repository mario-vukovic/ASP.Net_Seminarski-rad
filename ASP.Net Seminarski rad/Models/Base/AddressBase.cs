namespace ASP.Net_Seminarski_rad.Models.Base
{
    public abstract class AddressBase
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string CityPO { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public AddressTypeEnum AddressType { get; set; }
    }
}
