namespace QuranApp.Models
{
    public class Surahs
    {
        public long number { get; set; }
        public string name { get; set; }
        public string  englishName { get; set; }
        public string englishNameTranslation { get; set; }
        public string revelationType { get; set; }
        public List<Ayahs>? ayahs { get; set; }
    }
}

/*
 "number": 1,
   "name": "سُورَةُ ٱلْفَاتِحَةِ",
   "englishName": "Al-Faatiha",
   "englishNameTranslation": "The Opening",
   "revelationType": "Meccan",
   "ayahs" 
 */