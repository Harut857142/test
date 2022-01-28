using System;
using System.Collections.Generic;
using Gas.Shared.Models.Core.Paging;

namespace Gas.Shared.Models.Core
{
    
    [Serializable]
    public class BookCollectionFilter : PagedResultBase
    {
        public string SearchType { get; set; }
        public int? Id { get; set; }
        public string Title { get; set; }
        public DateTime? CreationDateFrom { get; set; } = null;
        public DateTime? CreationDateTo { get; set; } = null;

        public BookCollectionFilter()
        {
            
        }
        public BookCollectionFilter(int page, int size)
        {
            PageSize = size;
            CurrentPage = page;
        }
    }
}