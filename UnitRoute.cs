namespace CReiss.Core
{
    public class UnitRoute
    {

        public int Id { get; set; }
        public List<UnitEvent> Events { get; set; } = new List<UnitEvent>();
        public double TotalTime
        {
            get
            {
                if (this.Events.Count > 1)
                {
                    return this.Events[this.Events.Count - 1].EventDateTime.Subtract(this.Events[0].EventDateTime).TotalSeconds / 86400;
                }
                else
                {
                    return 0;
                }
            }
        }

    }

}
