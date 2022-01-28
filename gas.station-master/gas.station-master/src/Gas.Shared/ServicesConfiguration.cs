using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using DbProvider;
using Microsoft.EntityFrameworkCore;
using Gas.Shared.Services;
using Gas.Shared.DbProvider;
using Gas.Shared.Repository;
using Gas.Shared.Repository.Device;
using Gas.Shared.Repository.File;
using Gas.Shared.Repository.Permission;
using Gas.Shared.Repository.Role;
using Gas.Shared.Repository.User;

namespace Gas.Shared
{
    public static class ServicesConfiguration
    {
        public static void AddShared(this IServiceCollection services, DbProviderOptions dbProviderOptions)
        {
            // add db context
            services.AddDbContext<Context>(
                options =>
                {
                    options.UseMySql(dbProviderOptions.MssqlConnectionString,b =>
                    {
                        b.MigrationsAssembly("Gas.Admin");
                    }).EnableSensitiveDataLogging() // <-- These two calls are optional but help
                        .EnableDetailedErrors();
                }, ServiceLifetime.Scoped);
            
            // add repositories
            services.AddTransient<UserRepository>();
            services.AddTransient<PermissionRepository>();
            services.AddTransient<RoleRepository>();
            services.AddTransient<FileRepository>();
            services.AddTransient<DeviceRepository>();
            
            // add helper services
            services.AddTransient<EncryptionService>();
            services.AddTransient<AuthorizationService>();
            services.AddTransient<AuthorizeUserHelper>();
            services.AddTransient<FileService>();

        }
    }
}
