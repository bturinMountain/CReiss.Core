namespace CReiss.Core.Units
{

    public class MonthDemurrage
    {
        public string Month { get; set; } = String.Empty;
        public List<DemurrageDay> Days { get; set; } = new List<DemurrageDay>();
    }

    public class DemurrageDay
    {
        public DateTime EventDate { get; set; }
        public int UnitsBnsf { get; set; }
        public int UnitsCReiss { get; set; }
    }

}
