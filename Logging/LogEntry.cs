namespace CReiss.Core.Logging
{

    public class LogEntry
    {
        public short LogLevel { get; set; } = 0;
        public string Action { get; set; } = String.Empty;
        public DateTime ActionDateTime { get; set; } = DateTime.MinValue;
    }

}
