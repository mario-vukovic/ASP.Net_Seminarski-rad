using ASP.Net_Seminarski_rad.Models.Binding;
using ASP.Net_Seminarski_rad.Models.Dbo;
using ASP.Net_Seminarski_rad.Models.ViewModel;

namespace ASP.Net_Seminarski_rad.Services.Interface;

public interface IUserService
{
    Task<List<ApplicationUserViewModel>> GetAllUsersAsync();
    Task<ApplicationUser> CreateUserAsync(ApplicationUserBinding model, string role);

}