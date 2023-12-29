using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuranApp.Models;

namespace QuranApp.Infrastructure
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public int TotalPages { get; private set; }

        public PaginatedList(IQueryable<T> source, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = source.Count();
            TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);

            this.AddRange(source.Skip(PageIndex * PageSize).Take(PageSize));
        }

        public PaginatedList(IQueryable<T> ayahToDisplay,int totalPages, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = totalPages;
            TotalPages = totalPages;
            //var listOfAyahPerPage = SortQuranPerPage(pageIndex,source1).AsQueryable();
            var coll = ayahToDisplay.Skip(PageIndex * 0).ToList();
            var nexted = coll.Take(PageSize).ToList();
            this.AddRange(nexted);
            //this.AddRange(source1.Skip(PageIndex * PageSize).Take(PageSize));
        }

        public bool HasPreviousPage => (PageIndex > 1);

        public bool HasNextPage => (PageIndex + 1 < TotalPages);
    }

}
