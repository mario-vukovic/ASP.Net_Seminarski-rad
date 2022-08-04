using ASP.Net_Seminarski_rad.Models.Base;
using ASP.Net_Seminarski_rad.Models.Dbo;

namespace ASP.Net_Seminarski_rad.Models.Binding
{
    public class ApplicationUserUpdateBinding:ApplicationUser
    {
        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Dob { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

    }
}
