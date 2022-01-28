using System.Linq;
using Microsoft.EntityFrameworkCore;
using Gas.Shared.Models.Core;
using Gas.Shared.Models.Core.Device;
using Gas.Shared.Models.Core.Permission;
using Gas.Shared.Models.Core.User;

namespace Gas.Shared.DbProvider
{
    public class Context : DbContext
    {
        // user and role part
        public DbSet<Permission> Permissions { get; set; }
        
        public DbSet<Role> Roles { get; set; }
        
        public DbSet<RolePermission> RolePermissions { get; set; }
        
        public DbSet<UserRole> UserRoles { get; set; }
        
        public DbSet<User> Users { get; set; }
        
        // Book information should be finished now ✅
        public DbSet<File> Files { get; set; }
        public DbSet<Device> Devices { get; set; }
        
        public Context(DbContextOptions<Context> options)
        : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(modelbuilder);
        }
    }
}