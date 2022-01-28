using System.Collections.Generic;
using Gas.Admin.Models.Role;

namespace Gas.Admin.Models.User
{
    public class UserEditVm : UserBaseVm
    {
        public int Id { get; set; }
        public IList<Shared.Models.Core.Permission.Role> Roles { get; set; }
        public UserEditVm(Shared.Models.Core.User.User user)
        {
            this.User = user;
            Roles = new List<Shared.Models.Core.Permission.Role>();
        }
    }
}