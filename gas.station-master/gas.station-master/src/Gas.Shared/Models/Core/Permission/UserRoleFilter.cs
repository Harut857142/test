using Gas.Shared.Models.Core.Filter;

namespace Gas.Shared.Models.Core.Permission
{
    public class UserRoleFilter : FilterBase
    {
        public int? UserId { get; set; }
    }
}