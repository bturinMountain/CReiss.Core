using CReiss.Core.Locations;

namespace CReiss.Core.Routes
{

    public class PlantRouteAverage
    {
        public Location OriginLocation { get; set; } = new Location();
        public Location DestinationLocation { get; set; } = new Location();
        public double AverageTravelTime { get; set; }
        public double AverageTravelTime30Days { get; set; }
        public int TotalUnits { get; set; }
        public int TotalUnitsViaStPaul { get; set; }
    }

}
