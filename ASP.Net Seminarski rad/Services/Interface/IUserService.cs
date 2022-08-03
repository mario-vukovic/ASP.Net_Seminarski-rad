using ASP.Net_Seminarski_rad.Models.Binding;
using ASP.Net_Seminarski_rad.Models.Dbo;
using ASP.Net_Seminarski_rad.Models.ViewModel;

namespace ASP.Net_Seminarski_rad.Services.Interface;

public interface IUserService
{
    Task<ApplicationUser> CreateUserAsync(ApplicationUserBinding model, string role);
    Task<ApplicationUser> CreateNewUserAsync(ApplicationUserBinding model, string role);
    Task<List<ApplicationUserViewModel>> GetAllUsersAsync();
    Task<ApplicationUserViewModel> GetUserAsync(string id);
    Task<ApplicationUserViewModel> DeleteUserAsync(string id);
    Task<ApplicationUserViewModel> UpdateUserAsync(ApplicationUserBinding model);
}