namespace CReiss.Core
{

    public class UnitException : UnitEventBase
    {
        public DateTime? DepartedOn { get; set; }
        public DateTime ArrivedOn { get; set; }
        public DateTime? ETA { get; set; }
        public int? TravelTime { get; set; }
        public string BadOrderDescription { get; set; } = String.Empty;
    }

}
