using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Gas.Shared.Models.Core.Auth;
using Gas.Shared.Models.Core.Permission;
using Gas.Shared.Models.Core.User;
using Gas.Shared.Repository.User;

namespace Gas.Shared.Services
{
    /// <summary>
    /// Authorize Class for checking for permissions
    /// </summary>
    public class AuthorizationService
    {
        private readonly UserRepository _userRepository;
        private readonly EncryptionService _encryptionService;

        public AuthorizationService(UserRepository userRepository, EncryptionService encryptionService)
        {
            _userRepository = userRepository;
            _encryptionService = encryptionService;
        }
        
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }        
        
        /// <summary>
        /// Has Permission method
        /// </summary>
        /// <param name="userPermissions"></param>
        /// <param name="module"></param>
        /// <param name="permissionNumberList"></param>
        /// <returns></returns>
        public static AuthorizationState HasPermission(List<UserRole> userRoles, int module, ICollection<int> permissionNumberList)
        {
            return CheckPermissionsMatch(userRoles, module, permissionNumberList);
        }

        public User Login(string login, string password)
        {
            var user = _userRepository.getByEmail(login);
            
            if (user == null)
                return null;

            string hashedPassword = _encryptionService.CryptPasswordWithSalt(password, user.Salt);

            return _userRepository.getByEmailAndhash(login, hashedPassword);
        }
        
        /// <summary>
        /// Check for permissions
        /// </summary>
        /// <param name="userPermissions"></param>
        /// <param name="module"></param>
        /// <param name="permissionNumberList"></param>
        /// <returns></returns>
        private static AuthorizationState CheckPermissionsMatch(List<UserRole> userRoles, int module, ICollection<int> permissionNumberList)
        {
            try
            {
                if (userRoles == null)
                    return AuthorizationState.Forbidden;

                if (userRoles.Any(r => r.Role.SystemRole))
                    return AuthorizationState.HasPermission;
                Dictionary<int, HashSet<int>> userPermissions = new Dictionary<int, HashSet<int>>();

                if (userRoles.Any(role => role.Role.RolePermissions.Any(perm => permissionNumberList.Contains(perm.Permission.PermissionNumber))))
                {
                    return AuthorizationState.HasPermission;
                }

                return AuthorizationState.Forbidden;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
