using ASP.Net_Seminarski_rad.Models.ViewModel;

namespace ASP.Net_Seminarski_rad.Services.Interface;

public interface IFileStorageService
{
    Task<FileStorageViewModel> AddFileToStorage(IFormFile file);
    Task<bool> DeleteFile(int id);
    Task<FileStorageExpendedViewModel> GetFile(long id);
}