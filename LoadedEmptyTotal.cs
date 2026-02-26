using CReiss.Core.Locations;
using System.Collections.Generic;

namespace CReiss.Core
{

    public class LoadedEmptyTotal
    {
        public DateTime? EventDate { get; set; }
        public Location Location { get; set; } = new Location();
        public List<KeyValuePair<string, Int32>> Destinations { get; set; } = new List<KeyValuePair<string, int>>();
        public int OfflineTotalUnits { get; set; } = 0; 
        public int TotalUnits { get; set; } = 0;
        public int TotalWeightNetTons { get; set; } = 0;
        public int TotalExceptions { get; set; } = 0;
        public int TotalCpStatus { get; set; } = 0;
        public bool IsLoaded { get; set; } = false;
        public double AvgTimeLoadToEmpty { get; set; } = 0;
        public double AvgTransitTimeFromDock { get; set; } = 0;
        public double AvgDaysAtLocation
        {
            get
            {
                return this.UnitDwellTotals.Sum(x => x.TotalUnits) is int w && w != 0 ? this.UnitDwellTotals.Sum(x => x.TotalUnits * x.DaysAtLocation) / w : 0;
            }
        }
        //
        public List<UnitDwellTotal> UnitDwellTotals { get; private set; } = new List<UnitDwellTotal>();
    }

    public class UnitDwellTotal
    {
        public int LocationId { get; set; }
        public int TotalUnits { get; set; }
        public double DaysAtLocation { get; set; }
        public bool IsLoaded { get; set; }
    }

}
