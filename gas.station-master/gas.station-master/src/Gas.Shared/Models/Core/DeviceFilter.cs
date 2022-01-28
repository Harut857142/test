using System;
using System.Collections.Generic;
using Gas.Shared.Models.Core.Paging;

namespace Gas.Shared.Models.Core.Device
{
    
    [Serializable]
    public class DeviceFilter : PagedResultBase
    {
        public string SearchType { get; set; }
        public int? Id { get; set; }
        public int? Module { get; set; }
        public int? UserId { get; set; }
        public string ModuleName { get; set; }
        public int? Device { get; set; }
        public string DeviceName { get; set; }
        public string Description { get; set; }
        public DateTime? CreationDateFrom { get; set; } = null;
        public DateTime? CreationDateTo { get; set; } = null;

        public DeviceFilter()
        {
            
        }
        public DeviceFilter(int page, int size)
        {
            PageSize = size;
            CurrentPage = page;
        }
    }
}