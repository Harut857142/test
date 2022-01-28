using System.Collections.Generic;
using Gas.Admin.Models.Role;

namespace Gas.Admin.Models.User
{
    public class UserAddVm : UserBaseVm
    {
        public IList<Shared.Models.Core.Permission.Role> Roles { get; set; }
        public UserAddVm()
        {
            Roles = new List<Shared.Models.Core.Permission.Role>();
        }

    }
}