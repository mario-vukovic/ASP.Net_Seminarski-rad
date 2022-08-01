namespace ASP.Net_Seminarski_rad.Models.Dbo.Base
{
    public interface IEntityBase
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
    }
}
