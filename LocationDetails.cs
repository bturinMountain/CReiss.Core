namespace CReiss.Core
{

    public class LocationDetails : Location
    {

        public string CommonName { get; set; } = String.Empty;
        public string DisplayName { get; set; } = String.Empty;
        public string State { get; set; } = String.Empty;
        public bool IsDefault { get; set; } = false;
        public bool IsActive { get; set; } = false;


    }

}
