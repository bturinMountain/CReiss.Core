namespace CReiss.Core.Import
{

    public class DailyImport
    {
        public DateTime ImportDateLocal { get; set; } = DateTime.MinValue;
        public List<ImportFile> ImportFiles { get; set; } = new List<ImportFile>();
    }

}
