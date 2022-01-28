using System;
using System.Collections.Generic;
using Gas.Shared.Models.Core.Paging;

namespace Gas.Shared.Models.Core.User
{
    
    [Serializable]
    public class UserFilter : PagedResultBase
    {
        public string SearchType { get; set; }
        public string FullName { get; set; }
        public DateTime? CreationDateFrom { get; set; } = null;
        public DateTime? CreationDateTo { get; set; } = null;

        public UserFilter()
        {
            
        }
        public UserFilter(int page, int size)
        {
            PageSize = size;
            CurrentPage = page;
        }
    }
}