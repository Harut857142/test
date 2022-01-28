using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using Gas.Shared.Models.Core;
using Gas.Shared.Models.Core.Paging;

namespace Gas.Admin.Models.Author
{
    public class AuthorVm
    {
        public string SearchType { get; set; }
        public string Title { get; set; }
        public DateTime? CreationDateFrom { get; set; }
        public DateTime? CreationDateTo { get; set; }
        public PagedResult<Shared.Models.Core.Author> List { get; set; }
        public bool IsEmpty()
        {
            return String.IsNullOrEmpty(SearchType);
        }
        
        public Shared.Models.Core.Author ParentAuthor { get; set; } 

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
        public AuthorVm()
        {
            List = new PagedResult<Shared.Models.Core.Author>();
        }
        public AuthorVm(PagedResult<Shared.Models.Core.Author> list)
        {
            List = list;
        }

        public AuthorFilter GetFilter()
        {
            return new AuthorFilter()
            {
                SearchType = SearchType,
                Title = Title,
                CreationDateFrom = CreationDateFrom,
                CreationDateTo = CreationDateTo,
            };
            
        }

        public void FromFilter(AuthorFilter filter)
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