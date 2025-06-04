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

}
