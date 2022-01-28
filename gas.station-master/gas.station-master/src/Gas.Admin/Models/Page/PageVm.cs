using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using Gas.Shared.Models.Core;
using Gas.Shared.Models.Core.Paging;

namespace Gas.Admin.Models.Page
{
    public class PageVm
    {
        public int? ParentId { get; set; }
        public string SearchType { get; set; }
        public string Title { get; set; }
        public DateTime? CreationDateFrom { get; set; }
        public DateTime? CreationDateTo { get; set; }
        public PagedResult<Shared.Models.Core.Page> List { get; set; }
        public bool IsEmpty()
        {
            return String.IsNullOrEmpty(SearchType);
        }
        
        public Shared.Models.Core.Page ParentPage { get; set; } 

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
        public PageVm()
        {
            List = new PagedResult<Shared.Models.Core.Page>();
        }
        public PageVm(PagedResult<Shared.Models.Core.Page> list)
        {
            List = list;
        }

        public PageFilter GetFilter()
        {
            return new PageFilter()
            {
                SearchType = SearchType,
                Title = Title,
                CreationDateFrom = CreationDateFrom,
                CreationDateTo = CreationDateTo,
            };
            
        }

        public void FromFilter(PageFilter filter)
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