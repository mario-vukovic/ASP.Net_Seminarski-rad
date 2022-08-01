namespace ASP.Net_Seminarski_rad.Models.Binding
{
    public class ApplicationUserBinding
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime Dob { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public AddressBinding UserAddress { get; set; }
    }
}
