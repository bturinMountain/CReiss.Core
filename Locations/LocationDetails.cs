namespace CReiss.Core.Locations
{

    public class LocationDetails : Location
    {

        public string CommonName { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
		public bool IsDefault { get; set; } = false;
		public DateTime LastEventDateTime { get; set; } = DateTime.MinValue;
		public bool IsActive { get; set; } = false;


    }

}
