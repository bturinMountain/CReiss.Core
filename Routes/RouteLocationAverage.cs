using CReiss.Core.Locations;

namespace CReiss.Core.Routes
{

    public class RouteLocationAverage: PlantRouteAverage
    {
        public int RouteId { get; set; }
        public Location Location { get; set; } = new Location();
        public double AverageDwellTime { get; set; }
        public double AverageExceptions { get; set; }
        public double TotalUnits { get; set; }
        public bool IsFirst {  get; set; }
        public bool IsLast { get; set; }
        public bool IsLoaded { get; set; }
        public int RouteLocationId { get; set; }

    }

}
