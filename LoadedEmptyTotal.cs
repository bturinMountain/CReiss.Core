using CReiss.Core.Locations;

namespace CReiss.Core
{

    public class LoadedEmptyTotal
    {
        public Location Location { get; set; } = new Location();
        public List<KeyValuePair<string, Int32>> Destinations { get; set; } = new List<KeyValuePair<string, int>>();
        public int OfflineTotalUnits { get; set; } = 0; 
        public int TotalUnits { get; set; } = 0;
        public int TotalWeightNetTons { get; set; } = 0;
        public int TotalExceptions { get; set; } = 0;
        public bool IsLoaded { get; set; } = false;
    }

}
