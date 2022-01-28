using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Gas.Admin.Models;
using Gas.Admin.Models.Permission;
using Gas.Admin.ModelValidation.Auth;
using Gas.Shared.Models.Core.Auth;
using Gas.Shared.Models.Core.Permission;
using Gas.Shared.Repository.Permission;

namespace Gas.Admin.Controllers
{
    [AuthorizeUser((int)Modules.Permission, new int[] { (int)PermissionModule.Index })]
    public class PermissionController : Controller
    {
        private readonly PermissionRepository _permissionRepository;

        public PermissionController(PermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }
        
        [Route("/Permission")]
        [Route("/Permission/Index")]
        [HttpGet]
        public IActionResult Index(PermissionPagingVm paging)
        {
            var model = new PermissionVm();
            model.List = _permissionRepository.GetList(new PermissionFilter() { CurrentPage =  paging.Page, PageSize = paging.PageSize});
            return View(model);
        }

        [AuthorizeUser((int)Modules.Permission, new int[] { (int)PermissionModule.Edit })]
        [HttpGet]
        [Route("/Permission/Add")]
        public IActionResult Add()
        {
            return View();
        }

        
        [AuthorizeUser((int)Modules.Permission, new int[] { (int)PermissionModule.Edit })]
        [HttpPost]
        [Route("/Permission/Add")]
        public IActionResult Add(PermissionAddPostVm model)
        {
            _permissionRepository.Add(model.GetDbModel());
            _permissionRepository.Save();
            return RedirectToAction("Index");
        }

        [AuthorizeUser((int)Modules.Permission, new int[] { (int)PermissionModule.Edit })]
        [HttpGet]
        [Route("/Permission/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var permission = _permissionRepository.Get(id);
            PermissionEditVm model = new PermissionEditVm(permission);
            
            return View(model);
        }

        
        [AuthorizeUser((int)Modules.Permission, new int[] { (int)PermissionModule.Edit })]
        [HttpPost]
        [Route("/Permission/Edit")]
        public IActionResult Edit(PermissionEditVm model)
        {
            _permissionRepository.Update(model.Id, model.ModuleNumber, model.ModuleName,model.PermissionNumber,model.PermissionName, model.Description);
            _permissionRepository.Save();
            return RedirectToAction("Index");
        }
        
        [AuthorizeUser((int)Modules.Permission, new int[] { (int)PermissionModule.Edit })]
        [HttpPost]
        [Route("/Permission/Delete")]
        public IActionResult Delete([FromBody] IEnumerable<int> model)
        {
            
            foreach (var item in model)
            {
                _permissionRepository.Delete(item);
            }
            _permissionRepository.Save();
            return new JsonResult(new {});
        }
        
        [AuthorizeUser((int)Modules.Permission, new int[] { (int)PermissionModule.Edit })]
        [HttpPost]
        [Route("/Permission/Deletes")]
        public IActionResult Deletes(DeleteItemsVm model)
        {
            foreach (var item in model.Items)
            {
                _permissionRepository.Delete(item);
            }
            _permissionRepository.Save();

            return Redirect(model.ReturnUrl);
        }
    }
}