namespace CReiss.Core.Import
{

    public class ImportFile
    {

        private const string DIR_YEAR_FORMAT = "yyyy";
        private const string DIR_MONTH_FORMAT = "MM MMMM";
        private const string FILE_FORMAT = "yyyy-MM-dd hh-mm-ss";
        private const string FILE_EXTENSION = "csv";

        public int Id { get; set; } = 0;
        public DateTime ReceviedOn { get; set; } = DateTime.MinValue;
        public DateTime ImportFileDate { get; set; } = DateTime.MinValue;


        public string FilePath
        {
            get
            {
                return String.Concat(this.ReceviedOn.ToString(DIR_YEAR_FORMAT), "\\", this.ReceviedOn.ToString(DIR_MONTH_FORMAT), "\\", this.FileName);
            }
        }
        public string FileName
        {
            get
            {
                return String.Concat(this.ReceviedOn.ToString(FILE_FORMAT), ".", FILE_EXTENSION);
            }
        }

    }

}
