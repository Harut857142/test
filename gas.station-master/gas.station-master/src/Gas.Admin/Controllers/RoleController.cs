using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Gas.Admin.Models;
using Gas.Admin.Models.Role;
using Gas.Admin.ModelValidation.Auth;
using Gas.Shared.Models.Core.Auth;
using Gas.Shared.Models.Core.Permission;
using Gas.Shared.Models.Core.Role;
using Gas.Shared.Repository.Permission;
using Gas.Shared.Repository.Role;

namespace Gas.Admin.Controllers
{
    [AuthorizeUser((int)Modules.Role, new int[] { (int)RoleModule.Index })]
    public class RoleController : Controller
    {
        private readonly RoleRepository _roleRepository;
        private readonly PermissionRepository _permissionRepository;

        public RoleController(
            RoleRepository roleRepository,
            PermissionRepository permissionRepository
            )
        {
            _roleRepository = roleRepository;
            _permissionRepository = permissionRepository;
        }
        [Route("/Role")]
        [Route("/Role/Index")]
        [HttpGet]
        public IActionResult Index(RolePagingVm paging)
        {
            var model = new RoleVm();
            model.List = _roleRepository.GetList(new RoleFilter() { CurrentPage =  paging.Page, PageSize = paging.PageSize});
            return View(model);
        }

        [AuthorizeUser((int)Modules.Role, new int[] { (int)RoleModule.Edit })]
        [HttpGet]
        [Route("/Role/Add")]
        public IActionResult Add()
        {
            RoleEditVm model = new RoleEditVm();
            model.AllPermissions = _permissionRepository.GetList(new PermissionFilter(1, 10000)).Results;   
            return View(model);
        }

        
        [AuthorizeUser((int)Modules.Role, new int[] { (int)RoleModule.Edit })]
        [HttpPost]
        [Route("/Role/Add")]
        public IActionResult Add(RoleAddPostVm model)
        {
            var inserted = _roleRepository.Add(model.GetDbModel(), model.NewPermissions);
            return RedirectToAction("Index");
        }

        [AuthorizeUser((int)Modules.Role, new int[] { (int)RoleModule.Edit })]
        [HttpGet]
        [Route("/Role/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var role = _roleRepository.Get(id);
            RoleEditVm model = new RoleEditVm(role);
            model.AllPermissions = _permissionRepository.GetList(new PermissionFilter(1, 10000)).Results;   
            return View(model);
        }

        [AuthorizeUser((int)Modules.Role, new int[] { (int)RoleModule.Edit })]
        [HttpPost]
        [Route("/Role/Edit")]
        public IActionResult Edit(RoleEditVm model)
        {
            _roleRepository.Update(model.Id, model.Name, model.SystemName, model.Description, model.SystemRole, model.Active, model.NewPermissions);
            _roleRepository.Save();
            return RedirectToAction("Index");
        }
        
        [AuthorizeUser((int)Modules.Role, new int[] { (int)RoleModule.Edit })]
        [HttpPost]
        [Route("/Role/Delete")]
        public IActionResult Delete([FromBody] IEnumerable<int> model)
        {
            
            foreach (var item in model)
            {
                _roleRepository.Delete(item);
            }
            _roleRepository.Save();
            return new JsonResult(new {});
        }
        
        [AuthorizeUser((int)Modules.Role, new int[] { (int)RoleModule.Edit })]
        [HttpPost]
        [Route("/Role/Deletes")]
        public IActionResult Deletes(DeleteItemsVm model)
        {
            foreach (var item in model.Items)
            {
                _roleRepository.Delete(item);
            }
            _roleRepository.Save();

            return Redirect(model.ReturnUrl);
        }
    }
}