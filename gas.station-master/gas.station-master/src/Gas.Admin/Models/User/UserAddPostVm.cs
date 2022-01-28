using System.Collections.Generic;

namespace Gas.Admin.Models.User
{
    public class UserAddPostVm : UserBaseVm
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FullName { get; set; }
        public List<int> Permissions { get; set; }
        public List<int> Offices { get; set; }
        public Shared.Models.Core.User.User GetDbModel()
        {
            return new Shared.Models.Core.User.User()
            {
                
            };
        }
    }
}