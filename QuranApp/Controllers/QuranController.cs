using System.Collections;
using System.Collections.Immutable;
using Microsoft.AspNetCore.Mvc;
using QuranApp.Models;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Security;
using QuranApp.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Moq;
using QuranApp.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuranApp.Controllers
{
    public class QuranController : Controller
    {
        private readonly ILogger<QuranController> _logger;
        private List<Surahs> _surahsPerPage;
        public int _pageNumber;
        public int _juzNumber;

        public QuranController(ILogger<QuranController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //return View();
            return RedirectToAction("FullQuran");
        }

        [HttpGet]
        public IActionResult Edition(int? pageNumber)
        {
            var apiHelper = new QurantApiEngine();
            var editions = apiHelper.GetAllEditions().OrderByDescending(a => a.Name).ToList();
            ViewData["EditionList"] = editions;
            pageNumber ??= 0;
            const int pageSize = 15;
            var toRender = new PaginatedList<Edition>(editions.AsQueryable(), pageNumber ?? 1, pageSize);
            return View(toRender);
        }

        [HttpGet]
        public IActionResult FullQuran(string edition, int? pageNumber)
        {
            var apiHelper = new QurantApiEngine();
            var listOfAyahs = new List<string>();
            var quran = apiHelper.GetQuranData("ar.alafasy");
            var totalSurahs = GetNumberOfSurah(quran);
            var ayahsPerSurah = GetTotalAyahPerSurah(quran);
            var totalPagesOfQuran = GetTotalPages(quran);
            if(pageNumber == null || pageNumber == 0) pageNumber = 1;
            var ayahToDisplay = SortQuranPerPage((int)pageNumber, quran?.surahs)?.AsQueryable();
            ViewData["EditionList"] = quran;
            ViewData["TotalSurahs"] = totalSurahs;
            ViewData["TotalPages"] = totalPagesOfQuran;
            ViewData["AyahsPerSurahs"] = ayahsPerSurah;
            ViewData["SurahList"] = _surahsPerPage;
            ViewData["PageNumber"] = _pageNumber;
            ViewData["JuzNumber"] = _juzNumber;
            //GetSurahName(pageNumber, quran?.surahs);

            var surahDeserialized = quran.surahs.AsQueryable();

            int pageSize = ayahToDisplay.Count();

            //return View(db.Items.ToList());// Change this as following
            //var pagedList = ayahToDisplay.ToList().ToPagedList((int) pageNumber, pageSize);
            //return View(pagedList); //30 is the size of records in a single page

            return View(new PaginatedList<Ayahs>(ayahToDisplay, (int)totalPagesOfQuran, pageNumber ?? 1, pageSize));
        }

        public IActionResult OnGetPartial() =>
            new PartialViewResult
            {
                ViewName = "_AuthorPartialRP",
                ViewData = ViewData,
            };

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public int? GetNumberOfSurah(QuranData quran)
        {
            return quran?.surahs.Count();
        }

        public int? GetTotalPages(QuranData quran)
        {
            var total = quran?.surahs?.Last()?.ayahs?.Last()?.page;
            return total;
        }

        public Dictionary<long, int?>? GetTotalAyahPerSurah(QuranData quran)
        {
            var dict = new Dictionary<long, int?>();

            foreach (var surah in quran.surahs)
            {
                dict.Add(surah.number, surah?.ayahs?.Last().numberInSurah);
            }
            return dict;
        }

        private List<Ayahs>? SortQuranPerPage(int pageIndex, List<Surahs>? quran)
        {
            var ayahsPerPage = new List<Ayahs>();
            var surahsTotalPerPage = new List<Surahs>();
            HashSet<Surahs> hashSet = new HashSet<Surahs>();
            HashSet<int> pageNumber = new HashSet<int>();
            HashSet<int> juzNum = new HashSet<int>();
            //var surahsList = quran.ToList();
            if (quran == null) return ayahsPerPage;
            if (pageIndex == 0)
                pageIndex = 1;

            ayahsPerPage.AddRange(
                from surah in quran
                where pageIndex >= 0
                from ayah in surah.ayahs
                where pageIndex == ayah.page
                select ayah);

            foreach (var surah in quran)
            {
                foreach (var aya in surah.ayahs)
                {
                    if (pageIndex == aya.page)
                    {
                        var added = hashSet.Add(surah);
                        pageNumber.Add(aya.page);
                        juzNum.Add(aya.juz);
                    }
                }
            }

            _surahsPerPage = hashSet.ToList();
            _pageNumber = pageNumber.First();
            _juzNumber = juzNum.First();


            return ayahsPerPage;
        }


        private static List<string> GetSurahName(int? pageNumber, List<Surahs>? quran)
        {
            var surahName = new List<string>();
            if (quran == null) return surahName;
            if (pageNumber == 0)
                pageNumber = 1;

            foreach (var surah in quran)
            {
                foreach (var ayah in surah.ayahs)
                {
                    if (pageNumber == ayah.page)
                        surahName.Add(surah.name);
                }
            }
            return surahName;
        }



        //public int GetTotalNumberOfAyahInCurrentPage(Ayahs ayah)
        //{

        //}
    }
}
