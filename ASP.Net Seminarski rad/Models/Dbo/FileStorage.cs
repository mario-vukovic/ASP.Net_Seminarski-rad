using ASP.Net_Seminarski_rad.Models.Base;
using ASP.Net_Seminarski_rad.Models.Dbo.Base;

namespace ASP.Net_Seminarski_rad.Models.Dbo
{
    public class FileStorage : FileStorageBase, IEntityBase
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
    }
}
