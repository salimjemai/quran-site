using Microsoft.AspNetCore.Mvc.RazorPages;
using QuranApp.Infrastructure;
using QuranApp.Models;

namespace QuranApp.ViewModels
{
    public class PaginatedListEditionViewModel : PageModel
    {
        public PaginatedList<Edition>? _paginatedList { get; set; }

        public PaginatedListEditionViewModel(PaginatedList<Edition> v)
        {
            _paginatedList = v;
        }
    }
}
