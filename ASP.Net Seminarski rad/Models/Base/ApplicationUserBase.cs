namespace ASP.Net_Seminarski_rad.Models.Base
{
    public abstract class ApplicationUserBase
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Dob { get; set; }
        public string? Email { get; set; }


    }
}
