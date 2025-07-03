using CReiss.Core.Locations;

namespace CReiss.Core.Routes
{
    public class RouteAverage
    {
        public int Id { get; set; }
        public Location OriginLocation { get; set; } = new Location();
        public Location DestinationLocation { get; set; } = new Location();
        public List<RouteLocationAverage> LocationAverages { get; set; } = new List<RouteLocationAverage>();     
        public double AverageTravelTime
        {
            get
            {
                if (this.LocationAverages.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return this.LocationAverages.Sum(x => x.AverageTravelTime) / this.LocationAverages.Count;
                }
            }
        }
        public bool IsLoaded
        {
            get
            {
                if (this.LocationAverages.Count == 0)
                {
                    return false;
                }
                else
                {
                    return this.LocationAverages[0].IsLoaded;
                }
            }
        }
    }
}
