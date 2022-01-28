using Microsoft.AspNetCore.Mvc;

namespace Gas.Admin.Models.Author
{
    public class AuthorPagingVm
    {
        [FromQuery]
        public int PageSize { get; set; } = 10;
        [FromQuery]
        public int Page { get; set; } = 1;
    }
}