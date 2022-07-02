using ASP.Net_Seminarski_rad.Models.Dbo;

namespace ASP.Net_Seminarski_rad.Services.Interface;

public interface IIdentityService
{
    Task CreateRoleAsync(string role);
    Task CreateUserAsync(ApplicationUser applicationUser, string password, string role);
}