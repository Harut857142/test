using Microsoft.AspNetCore.Mvc;

namespace Gas.Admin.Models.Role
{
    public class RolePagingVm
    {
        [FromQuery]
        public int PageSize { get; set; } = 10;
        [FromQuery]
        public int Page { get; set; } = 1;
    }
}