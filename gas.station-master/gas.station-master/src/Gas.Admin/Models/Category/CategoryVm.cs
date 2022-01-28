using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using Gas.Shared.Models.Core;
using Gas.Shared.Models.Core.Paging;

namespace Gas.Admin.Models.Category
{
    public class CategoryVm
    {
        public int? ParentId { get; set; }
        public string SearchType { get; set; }
        public string Title { get; set; }
        public DateTime? CreationDateFrom { get; set; }
        public DateTime? CreationDateTo { get; set; }
        public PagedResult<Shared.Models.Core.Category> List { get; set; }
        public bool IsEmpty()
        {
            return String.IsNullOrEmpty(SearchType);
        }
        
        public Shared.Models.Core.Category ParentCategory { get; set; } 

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
        public CategoryVm()
        {
            List = new PagedResult<Shared.Models.Core.Category>();
        }
        public CategoryVm(PagedResult<Shared.Models.Core.Category> list)
        {
            List = list;
        }

        public CategoryFilter GetFilter()
        {
            return new CategoryFilter()
            {
                SearchType = SearchType,
                Title = Title,
                CreationDateFrom = CreationDateFrom,
                CreationDateTo = CreationDateTo,
            };
            
        }

        public void FromFilter(CategoryFilter filter)
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