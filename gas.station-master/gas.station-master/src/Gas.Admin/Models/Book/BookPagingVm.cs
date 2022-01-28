using Microsoft.AspNetCore.Mvc;

namespace Gas.Admin.Models.Book
{
    public class BookPagingVm
    {
        [FromQuery]
        public int PageSize { get; set; } = 10;
        [FromQuery]
        public int Page { get; set; } = 1;
        
        [FromQuery]
        public int? ParentId { get; set; }
    }
}