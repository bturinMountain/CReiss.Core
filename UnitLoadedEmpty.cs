namespace CReiss.Core
{

    public class UnitLoadedEmpty
    {
        public int GroupID { get; set; } = 0;
        public string WaybillNumber { get; set; } = String.Empty;
        public string Unit { get; set; } = String.Empty;
        public Location Location { get; set; } = new Location();
        public bool IsLoaded { get; set; } = false;
        public DateTime LoadedEventDate { get; set; } = DateTime.MinValue;
        public Location LoadedDestination { get; set; } = new Location();
        public DateTime? EmptiedEventDate { get; set; } = null;
        public Location EmptiedLocation { get; set; } = new Location();
        public string EventCode { get; set; } = String.Empty;
        public string EventStatus { get; set; } = String.Empty;

    }

}
