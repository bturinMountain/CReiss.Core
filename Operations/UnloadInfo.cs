using CReiss.Core.Locations;

namespace CReiss.Core.Operations
{

    public class UnloadInfo
    {
        public int Id { get; set; } = 0;
        public Location UnloadLocation { get; private set; } = new Location();
        public short UnloadedUnits { get; set; } = 0;
        public short UnitsToDayPad { get; set; } = 0;
        public short UnitsToStockPile { get; set; } = 0;
        public string Notes { get; set; } = String.Empty;
        public string SubmittedBy { get; set; } = String.Empty;

        public DateTime EventDateTimeUtc { get; set; } = DateTime.MinValue;

        public DateTime SubmittedOnUtc {  get; set; } = DateTime.MinValue;

    }

}
