using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Gas.Shared.Models.Core.Permission;

namespace Gas.Shared.Models.Core.User
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int? UserState { get; set; }
        public string Salt { get; set; }
        public DateTime CreationDate { get; set; }
        
        public bool Status { get; set; } = true;

        public virtual List<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}