using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Gas.Shared.DbProvider;
using Gas.Shared.Models.Core.Paging;
using Gas.Shared.Models.Core.Permission;
using Gas.Shared.Repository.Shared;

namespace Gas.Shared.Repository.User
{
    public class UserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context)
        {
            _context = context;
        }
        
        public PagedResult<Models.Core.User.User> GetList(PagedResultBase filter)
        {
            return _context.Users.Where(r => (r.Status))
                .Select(customerInformation => customerInformation).Include(r => r.UserRoles).ThenInclude(r => r.Role).AsQueryable().GetPaged(filter.CurrentPage, filter.PageSize);
        }
        
        public Models.Core.User.User getById(int id)
        {
            return _context.Users.Where(r => r.ID == id && r.Status)
                .Include(r => r.UserRoles)
                .ThenInclude(r => r.Role).FirstOrDefault();
        }
        public Models.Core.User.User getByEmail(string email)
        {
            return _context.Users.Where(r => r.Email == email && r.Status).Include(r => r.UserRoles).ThenInclude(r => r.Role).FirstOrDefault();
        }
        
        public Models.Core.User.User getByEmailAndhash(string email, string hash)
        {
            return _context.Users.Where(r => r.Email == email &&
                                             r.Password == hash && r.Status).Include(r => r.UserRoles).ThenInclude(r => r.Role).FirstOrDefault();
        }
        
        public Models.Core.User.User Update(Models.Core.User.User model, IEnumerable<int> roles)
        {
            var item = _context.Users.Where(
                r => r.Status
                     && r.ID == model.ID).ToList();
            if (!item.Any())
                return null;

            var toUpdate = item[0];
            toUpdate.Email = model.Email;
            toUpdate.FullName = model.FullName;
            toUpdate.Password = model.Password == null ? toUpdate.Password : model.Password;
            toUpdate.Salt = model.Salt == null ? toUpdate.Salt : model.Salt;
            toUpdate.UserState = model.UserState == null ? toUpdate.UserState : model.UserState;
            _context.Users.Update(toUpdate);
            _context.SaveChanges();

            this.UpdateUserRoles(toUpdate, roles);

            _context.SaveChanges();

            return this.getById(toUpdate.ID);
        }
        
        
        public void UpdateUserRoles(Models.Core.User.User user, IEnumerable<int> list)
        {
            
            foreach (var elem in user.UserRoles)
            {
                _context.UserRoles.Remove(elem);
            }
            
            foreach (var elem in list)
            {
                _context.UserRoles.Add(new UserRole()
                {
                    RoleId = elem,
                    User = user
                });
            }
        }
        public Models.Core.User.User Add(Models.Core.User.User model, IEnumerable<int> roles)
        {
            model.CreationDate = DateTime.UtcNow;
            model.Status = true;
            _context.Users.Add(model);
            _context.SaveChanges();

            this.UpdateUserRoles(model, roles);

            _context.SaveChanges();
            return model;
        }

        public bool Delete(int id)
        {
            var item = _context.Users.Where(
                r => r.Status
                     && r.ID == id).ToList();
            if (!item.Any())
                return false;

            var toUpdate = item[0];
            toUpdate.Status = false;
            _context.Users.Update(toUpdate);
            _context.SaveChanges();

            return true;
        }
    }
}