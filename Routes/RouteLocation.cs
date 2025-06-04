using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CReiss.Core.Routes
{

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
