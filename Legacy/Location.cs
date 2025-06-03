namespace CReiss.Core
{

    public enum LocationType
    {
        NotSet,
        Origin,
        InTransit,
        Plant
    }
    public enum DwellBucketType
    {
        NotSet,
        ZeroToThree,
        FourToTen,
        ElevenPlus
    }



    public class LocationWeight : LocationWeightBase
    {
        public int GrossWeightTons { get; set; } = 0;
    }




    public class LOrETotals
    {
        public LOrELocationTotals Origin { get; set; } = new LOrELocationTotals();
        public LOrELocationTotals InTransit { get; set; } = new LOrELocationTotals();
        public LOrELocationTotals Plants { get; set; } = new LOrELocationTotals();
        public List<DwellTotal> DwellTotals { get; set; } = new List<DwellTotal>();
    }

    public class LOrELocationTotals
    {
        public int Loaded { get; set; } = 0;
        public int Empty { get; set; } = 0;
        public double DwellAvg { get; set; } = 0;
    }




    public class UnitLocation : UnitLocationBase
    {
        public DateTime EventDateTime { get; set; } = DateTime.MinValue;
    }

    public class UnitLocationBase
    {
        public string Unit { get; set; } = String.Empty;
        public Location Location { get; set; } = new Location();
        public bool IsLoaded { get; set; } = false;
    }


    public class LocationDwell
    {
        // LocationTypeID, LocationID, Location, ArrivedOn, DaysAtLocation, IsLoaded, SortOrder, COUNT(Unit) AS TotalUnits
        public Location Location { get; set; } = new Location();
        public DateTime ArrivedOn { get; set; } = DateTime.MinValue;
        public double DaysAtLocation { get; set; } = 0;
        public bool IsLoaded { get; set; } = false;
        public int SortOrder { get; set; } = 0;
        public List<UnitDwell> Units { get; set; } = new List<UnitDwell>();
    }




    public class UnitDwell : UnitLocation
    {
        public string Destination {  get; set; } = String.Empty;
        public DateTime ArrivedOn { get; set; } = DateTime.MinValue;
        public DateTime DepartedOn { get; set; } = DateTime.MinValue;
        public string Status { get; set; } = String.Empty;
        public string Code { get; set; } = String.Empty;
        public double Dwell { get; set; } = 0;
        public int NetWeightTons { get; set; } = 0;
    }



    public class LOrETotal
    {
        public LocationType LocationType { get; set; } = LocationType.NotSet;
        public Location Location { get; set; } = new Location();
        public int TotalCars { get; set; } = 0;
        public int TotalExceptions { get; set; } = 0;
        public bool IsLoaded { get; set; } = false;
    }

    public class DwellTotal : LOrETotal
    {
        public DwellBucketType DwellBucketType { get; set; } = DwellBucketType.NotSet;

    }


    public class LocationWeightBase
    {
        public string Unit { get; set; } = String.Empty;
        public DateTime EventDate { get; set; } = DateTime.MinValue;
        public Location CurrentLocation { get; set; } = new Location();
        public Location Destination { get; set; } = new Location();
        public int NetWeightTons { get; set; } = 0;
        public bool IsLoaded { get; set; } = false;
    }
    //public class LocationWeight : LocationWeightBase
    //{
    //    public int GrossWeightTons { get; set; } = 0;
    //}
    public class UnitLocationLorE : LocationWeightBase
    {
        public string Track { get; set; } = String.Empty;
        public int PreviousGrossWeightTons { get; set; } = 0;
        public DateTime PreviousEventDate { get; set; } = DateTime.MinValue;
    }

}

