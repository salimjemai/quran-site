using QuranApp.Models;

namespace QuranApp.Infrastructure
{
    public class ApiResponse
    {
        public long code {get; set; }
        public string status { get; set; }
        public List<Edition>? data { get; set; }
    }
}
