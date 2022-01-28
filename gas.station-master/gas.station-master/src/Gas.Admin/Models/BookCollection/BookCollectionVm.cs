using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using Gas.Shared.Models.Core;
using Gas.Shared.Models.Core.Paging;

namespace Gas.Admin.Models.BookCollection
{
    public class BookCollectionVm
    {
        public string SearchType { get; set; }
        public string Title { get; set; }
        public DateTime? CreationDateFrom { get; set; }
        public DateTime? CreationDateTo { get; set; }
        public PagedResult<Shared.Models.Core.BookCollection> List { get; set; }
        public bool IsEmpty()
        {
            return String.IsNullOrEmpty(SearchType);
        }
        
        public Shared.Models.Core.BookCollection ParentBookCollection { get; set; } 

        public void ClearFilters()
        {
            if (SearchType != "Title")
                Title = null;

            if (SearchType != "CreationDate")
            {
                CreationDateFrom = null;
                CreationDateTo = null;   
            }
        }
        public BookCollectionVm()
        {
            List = new PagedResult<Shared.Models.Core.BookCollection>();
        }
        public BookCollectionVm(PagedResult<Shared.Models.Core.BookCollection> list)
        {
            List = list;
        }

        public BookCollectionFilter GetFilter()
        {
            return new BookCollectionFilter()
            {
                SearchType = SearchType,
                Title = Title,
                CreationDateFrom = CreationDateFrom,
                CreationDateTo = CreationDateTo,
            };
            
        }

        public void FromFilter(BookCollectionFilter filter)
        {
            SearchType = filter.SearchType;
            Title = filter.Title;
            CreationDateFrom = filter.CreationDateFrom;
            CreationDateTo = filter.CreationDateTo;
        }
        
        public static List<string> ReadAsList(IFormFile file)
        {
//            var result = new StringBuilder();
            List<string> result = new List<string>();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    result.Add(reader.ReadLine()); 
            }
            return result;
        }
    }
}