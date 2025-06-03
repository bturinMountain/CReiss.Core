namespace CReiss.Core
{

    public class UnitEventBase
    {
        public string Unit { get; set; } = String.Empty;
        public DateTime EventDateTime { get; set; } = DateTime.MinValue;
        public bool IsLoaded { get; set; } = false;
        public string WaybillNumber { get; set; } = String.Empty;
        public DateTime WaybillDate { get; set; } = DateTime.MinValue;
        public Location Location { get; set; } = new Location();
        public string Train { get; set; } = String.Empty;
        public List<string> Tracks { get; set; } = new List<string>();
        public Location Origin { get; set; } = new Location();
        public Location Destination { get; set; } = new Location();
        public int? NetWeightTons { get; set; } = 0;
    }

}
