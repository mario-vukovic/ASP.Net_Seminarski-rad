using ASP.Net_Seminarski_rad.Models.Base;
using ASP.Net_Seminarski_rad.Models.Dbo;

namespace ASP.Net_Seminarski_rad.Models.ViewModel
{
    public class ApplicationUserViewModel : ApplicationUser
    {
        public string? Id { get; set; }
    }
}
