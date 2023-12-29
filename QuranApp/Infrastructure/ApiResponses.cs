using QuranApp.Models;

namespace QuranApp.Infrastructure
{
    public class ApiResponses
    {
        
    }

    public class EditionResponse
    {
        public long code { get; set; }
        public string status { get; set; }
        public List<Edition>? data { get; set; }
    }

    public class FullQuranResponse
    {
        public long code { get; set; }
        public string status { get; set; }
        public QuranData? data { get; set; }
    }

    public class QuranData
    {
        public List<Surahs>? surahs { get; set; }
        public Edition? edition { get; set; }
    }
}
