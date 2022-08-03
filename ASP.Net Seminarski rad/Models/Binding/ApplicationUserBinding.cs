using ASP.Net_Seminarski_rad.Models.Base;

namespace ASP.Net_Seminarski_rad.Models.Binding
{
    public class ApplicationUserBinding:ApplicationUserBase
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime Dob { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public AddressBinding UserAddress { get; set; }

    }
}
