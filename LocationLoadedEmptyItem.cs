using CReiss.Core.Locations;

namespace CReiss.Core
{


    public class LocationLoadedEmpty
    {
        public Location Location { get; set; } = new Location();
        public List<LoadedEmptyItem> Loaded { get; set; } = new List<LoadedEmptyItem>();
        public List<LoadedEmptyItem> Empty { get; set; } = new List<LoadedEmptyItem>();
    }

    public class LoadedEmptyItem
    {
        public DateTime? EventDate { get; set; }
        public bool IsLoaded { get; set; }
        public int TotalUnits { get; set; }
        public int? TotalNetTons { get; set; }
    }



    public class LocationLoadedEmptyItem
    {
        public DateTime EventDate { get; set; }
        public Location LoadedDestination { get; set; } = new Location();
        public int? LoadedTotalCars { get; set; }
        public int? LoadedTotalNetTons { get; set; }
        public Location EmptyOrigin { get; set; } = new Location();
        public int? EmptyTotalCars { get; set; }
        public int? EmptyTotalNetTons { get; set; }
        // TODO: Location not string
        public Dictionary<string, List<UnitLoadedEmpty>> LoadedUnits { get; set; } = new Dictionary<string, List<UnitLoadedEmpty>>();
        public Dictionary<string, List<UnitLoadedEmpty>> EmptiedUnits { get; set; } = new Dictionary<string, List<UnitLoadedEmpty>>();
        public List<UnitLoadedEmpty> EnrouteUnits { get; set; } = new List<UnitLoadedEmpty>();
        public List<UnitLoadedEmpty> UnparentedUnits { get; set; } = new List<UnitLoadedEmpty>();
        public List<UnitLoadedEmpty> Exceptions { get; set; } = new List<UnitLoadedEmpty>();
    }



    public class Train
    {
        public int Id { get; set; }
        public Location Location { get; set; } = new Location();
        public Location Destination { get; set; } = new Location();
        public List<string> Units { get; set; } = new List<string>();
    }

}
