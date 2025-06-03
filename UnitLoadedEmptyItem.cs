namespace CReiss.Core
{

    public class UnitLoadedEmptyItem : UnitEventBase
    {
        public Location PreviousLocation { get; set; } = new Location();
        public int? PreviousNetWeightTons { get; set; } = 0;
        public DateTime PreviousEventDate { get; set; } = DateTime.MinValue;
    }

}
