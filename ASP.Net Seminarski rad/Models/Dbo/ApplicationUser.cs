using System.ComponentModel.DataAnnotations.Schema;
using ASP.Net_Seminarski_rad.Models;
using ASP.Net_Seminarski_rad.Models.Dbo.Base;
using MessagePack;
using Microsoft.AspNetCore.Identity;

namespace ASP.Net_Seminarski_rad.Models.Dbo
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime Dob { get; set; }
        public DateTime Created { get; set; }
        public ICollection<Address> Address { get; set; }
    }
}
