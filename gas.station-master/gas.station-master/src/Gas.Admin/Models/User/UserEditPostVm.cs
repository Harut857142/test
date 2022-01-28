using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gas.Admin.Models.User
{
    public class UserEditPostVm : UserBaseVm
    {
        [Required]
        public int Id { get; set; }
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
                ID = Id,
                Email = Email,
                Password = Password,
                FullName = FullName
            };
        }
    }
}