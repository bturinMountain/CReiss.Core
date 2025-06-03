using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CReiss.Core.Routes
{

    public class TrainRoute
    {
        public int Id { get; set; }
        public List<RouteLocation> Locations { get; set; } = new List<RouteLocation> { };
        public bool IsLoaded { get; set; }
        public double TotalTime
        {
            get
            {
                if (this.Locations.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return this.Locations[this.Locations.Count - 1].LastEventDateTime.Subtract(this.Locations[0].FirstEventDateTime).TotalSeconds / 86400;
                }
            }
        }
    }

    public class RouteLocation
    {
        public int Id { get; set; }
        public Location Location { get; set; } = new Location();
        public DateTime FirstEventDateTime { get; set; }
        public DateTime LastEventDateTime { get; set; }
        public double TravelTime { get; set; }
        public bool IsFirst { get; set; }
        public bool IsLast { get; set; }
        public bool IsLoaded { get; set; }
        public List<UnitEvent> Events { get; set; } = new List<UnitEvent>();
        public double DwellTime
        {
            get
            {
                return this.LastEventDateTime.Subtract(this.FirstEventDateTime).TotalSeconds / 86400;
            }
        }

    }

}
