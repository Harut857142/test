using System;
using System.Collections.Generic;
using Gas.Shared.Models.Core.Paging;

namespace Gas.Shared.Models.Core
{
    
    [Serializable]
    public class PageFilter : PagedResultBase
    {
        public bool SkipParent { get; set; } = false;
        public string SearchType { get; set; }
        public int? Id { get; set; }
        public int? ParentId { get; set; }
        public int? Type { get; set; }
        public string Title { get; set; }
        public DateTime? CreationDateFrom { get; set; } = null;
        public DateTime? CreationDateTo { get; set; } = null;

        public PageFilter()
        {
            
        }
        public PageFilter(int page, int size)
        {
            PageSize = size;
            CurrentPage = page;
        }
    }
}