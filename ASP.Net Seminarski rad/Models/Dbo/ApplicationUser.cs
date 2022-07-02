using ASP.Net_Seminarski_rad.Models;
using Microsoft.AspNetCore.Identity;

namespace ASP.Net_Seminarski_rad.Models.Dbo
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }


    }
}
