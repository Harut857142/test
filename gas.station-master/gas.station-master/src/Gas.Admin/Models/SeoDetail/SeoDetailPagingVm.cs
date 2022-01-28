using Microsoft.AspNetCore.Mvc;

namespace Gas.Admin.Models.SeoDetail
{
    public class SeoDetailPagingVm
    {
        [FromQuery]
        public int PageSize { get; set; } = 10;
        [FromQuery]
        public int Page { get; set; } = 1;
    }
}