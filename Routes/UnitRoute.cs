namespace CReiss.Core.Routes
{

    public class UnitRoute
    {

        public int Id { get; set; }
        public List<UnitEvent> Events { get; set; } = new List<UnitEvent>();
        public double TotalTime
        {
            get
            {
                if (Events.Count > 1)
                {
                    return Events[Events.Count - 1].EventDateTime.Subtract(Events[0].EventDateTime).TotalSeconds / 86400;
                }
                else
                {
                    return 0;
                }
            }
        }

    }

}
