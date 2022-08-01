namespace ASP.Net_Seminarski_rad.Models
{
    public static class Roles
    {
        public const string Admin = "Administrator";
        public const string Editor = "Editor";
        public const string Employee = "Employee";
        public const string BasicUser = "Basic user";
    }

    public enum AddressTypeEnum
    {
        House = 1,
        Apartment,
        Office
    }

}
