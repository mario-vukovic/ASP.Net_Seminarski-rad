using System.Net.Mime;
using ASP.Net_Seminarski_rad.Models.Base;

namespace ASP.Net_Seminarski_rad.Models.ViewModel
{
    public class FileStorageViewModel : FileStorageBase
    {
        public int Id { get; set; }
    }
    public class FileStorageExpendedViewModel : FileStorageBase
    {
        public int Id { get; set; }
        public string Base64 { get; set; }
        public FileStream FileStream { get; set; }
        public ContentDisposition ContentDisposition { get; set; }
    }

}
