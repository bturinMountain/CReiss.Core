namespace CReiss.Core.Locations
{

    public class Location
    {

        public int Id { get; set; } = 0;
        public LocationType Type { get; set; } = LocationType.NotSet;
        public string Name { get; set; } = string.Empty;
        public List<string> Tracks { get; set; } = new List<string>();
        public GeoPoint GeoPoint { get; set; } = new GeoPoint();
        public int Data { get; set; } = 0;
        public short SortOrder { get; set; } = 0;

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(Location))
                return false;
            var other = (Location)obj;
            return Equals(other.Name, Name);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                return Name.GetHashCode();
            }
        }

    }

}
