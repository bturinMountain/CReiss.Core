namespace CReiss.Core
{

    public class UnitEvent : UnitEventBase, ICloneable
    {

        public string EventCode { get; set; } = String.Empty;
        public string EventStatus { get; set; } = String.Empty;
        public string SwitchCode { get; set; } = String.Empty;

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }

}
