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

        public QuranController(ILogger<QuranController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edition(int? pageNumber)
        {
            var apiHelper = new QurantApiEngine();
            var editions = apiHelper.GetAllEditions().OrderByDescending(a=>a.Name).ToList();
            ViewData["EditionList"] = editions;
            pageNumber ??= 0;
            const int pageSize = 15;
            return View(new PaginatedList<Edition>(editions.AsQueryable(), pageNumber ?? 1, pageSize));
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
    }
}
