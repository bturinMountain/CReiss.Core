namespace CReiss.Core.Legacy
{

    public class Waybill
    {
        public string WaybillNumber { get; set; } = String.Empty;
        public string LorE { get; set; } = String.Empty;
        public string Unit { get; set; } = String.Empty;
        public DateTime WaybillDate { get; set; }
        public string Origin { get; set; } = String.Empty;
        public DateTime DepartureOn { get; set; }
        public string Location { get; set; } = String.Empty;
        public DateTime EventOn { get; set; }
        public string Destination { get; set; } = String.Empty;
        public DateTime? ArrivalOn { get; set; }
        public DateTime? ETA { get; set; }
        public int? TravelTime { get; set; }
        public int WeightNetTons { get; set; }
    }

    public class WaybillException : Waybill
    {
        public string BadOrderDescription { get; set; } = String.Empty;
    }

    public class WaybillLocation
    {
        public string Location { get; set; } = String.Empty;
        public DateTime EventOn { get; set; }
    }

    public class LocationDashboardItem
    {
        public string Location { get; set; } = String.Empty;
        public int? NumberOfCars { get; set; }
        public string LOrE { get; set; } = String.Empty;
        public string OriginDestination { get; set; } = String.Empty;
        public int? DwellDays { get; set; }
        public int? TripDays { get; set; }
        public int? EtaDays { get; set; }
        public int? EtaChange { get; set; }
    }

    public class DailyLAndEItem
    {
        public DateTime EventDate { get; set; }
        public string? LoadedDestination { get; set; }
        public LocationType LoadedDestinationType { get; set; } = LocationType.NotSet;
        public int? LoadedTotalCars { get; set; }
        public int? LoadedTotalNetTons { get; set; }
        public string? EmptyOrigin { get; set; }
        public LocationType EmptyOriginType { get; set; } = LocationType.NotSet;
        public int? EmptyTotalCars { get; set; }
        public int? PreviousTotalNetTons { get; set; }
    }

    public class AverageDwellTime
    {
        public LocationType LocationType { get; set; }
        public DateTime AsOfDate { get; set; }
        public double DwellTime { get; set; }
    }

}
