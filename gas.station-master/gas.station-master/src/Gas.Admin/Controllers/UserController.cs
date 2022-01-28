using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Gas.Admin.Models;
using Gas.Admin.Models.User;
using Gas.Admin.ModelValidation.Auth;
using Gas.Shared.Models.Core.Auth;
using Gas.Shared.Models.Core.Role;
using Gas.Shared.Models.Core.User;
using Gas.Shared.Repository.Permission;
using Gas.Shared.Repository.Role;
using Gas.Shared.Repository.User;
using Gas.Shared.Services;

namespace Gas.Admin.Controllers
{
    [AuthorizeUser((int)Modules.User, new int[] { (int)UserModule.Index })]
    public class UserController : Controller
    {
        private readonly UserRepository _userRepository;
        private readonly RoleRepository _roleRepository;
        private readonly PermissionRepository _permissionRepository;
        private readonly EncryptionService _encryptionService;

        public UserController(
            UserRepository userRepository,
            RoleRepository roleRepository,
            PermissionRepository permissionRepository,
            EncryptionService encryptionService
        )
        {
            _userRepository = userRepository;
            _permissionRepository = permissionRepository;
            _roleRepository = roleRepository;
            _encryptionService = encryptionService;
        }
        
        [Route("/User")]
        [Route("/User/Index")]
        [HttpGet]
        public IActionResult Index(UserPagingVm paging)
        {
            var model = new UserVm();
            var filter = new UserFilter() {CurrentPage = paging.Page, PageSize = paging.PageSize};
            model.List = _userRepository.GetList(filter);
            return View(model);
        }


        [AuthorizeUser((int)Modules.User, new int[] { (int)UserModule.Edit })]
        [HttpGet]
        [Route("/User/Add")]
        public IActionResult Add()
        {
            UserAddVm model = new UserAddVm();
            model.Roles = _roleRepository.GetList(new RoleFilter(){CurrentPage = 1, PageSize = 50000}).Results;
            return View(model);
        }

        
        [AuthorizeUser((int)Modules.User, new int[] { (int)UserModule.Edit })]
        [HttpPost]
        [Route("/User/Add")]
        public IActionResult Add(UserAddPostVm model)
        {
            // _permissionRepository.Add(model.GetDbModel());
            // _permissionRepository.Save();
            if (!ModelState.IsValid || model.ConfirmPassword != model.Password)
                return BadRequest();
            
            string salt = _encryptionService.HashedSaltGenerator();
            string hashedPassword = _encryptionService.CryptPasswordWithSalt(password: model.Password, HashedSalt: salt);
                
            _userRepository.Add(new User()
            {
                Email = model.Email,
                CreationDate = DateTime.Now,
                FullName = model.FullName,
                Password = hashedPassword,
                Salt = salt,
                UserState = 1,
            }, model.Permissions);
            
            return RedirectToAction("Index");
        }

        [AuthorizeUser((int)Modules.User, new int[] { (int)UserModule.Edit })]
        [HttpGet]
        [Route("/User/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var user = _userRepository.getById(id);
            user.Salt = null;
            user.Password = null;
            UserEditVm model = new UserEditVm(user);
            model.Roles = _roleRepository.GetList(new RoleFilter() {CurrentPage = 1, PageSize = 100000}).Results;
            return View(model);
        }

        
        [AuthorizeUser((int)Modules.User, new int[] { (int)UserModule.Edit })]
        [HttpPost]
        [Route("/User/Edit")]
        public IActionResult Edit(UserEditPostVm model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var user = _userRepository.getById(model.Id);
            if (user == null)
                return NotFound("User not found for update");

            var saveModel = model.GetDbModel();

            if (!String.IsNullOrEmpty(model.Password) && !String.IsNullOrEmpty(model.ConfirmPassword)
                                                      && model.Password == model.ConfirmPassword)
            {
                string salt = _encryptionService.HashedSaltGenerator();
                string hashedPassword = _encryptionService.CryptPasswordWithSalt(password: model.Password, HashedSalt: salt);
                saveModel.Password = hashedPassword;
                saveModel.Salt = salt;
            }
            else
            {
                saveModel.Password = null;
                saveModel.Salt = null;
            }

            _userRepository.Update(saveModel, model.Permissions);
            
            return RedirectToAction("Index");
        }

        [AuthorizeUser((int)Modules.User, new int[] { (int)UserModule.Edit })]
        [HttpPost]
        [Route("/User/Delete")]
        public IActionResult Delete([FromBody] IEnumerable<int> model)
        {
            
            foreach (var item in model)
            {
                _userRepository.Delete(item);
            }
            
            return new JsonResult(new {});
        }
        
        [AuthorizeUser((int)Modules.User, new int[] { (int)UserModule.Edit })]
        [HttpPost]
        [Route("/User/Deletes")]
        public IActionResult Deletes(DeleteItemsVm model)
        {
            foreach (var item in model.Items)
            {
                _userRepository.Delete(item);
            }

            return Redirect(model.ReturnUrl);
        }
    }
}