using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Gas.Admin.HostedServices;
using Microsoft.AspNetCore.Mvc;
using Gas.Admin.Models;
using Gas.Admin.Models.Device;
using Gas.Admin.ModelValidation.Auth;
using Gas.Shared.Models.Core;
using Gas.Shared.Models.Core.Auth;
using Gas.Shared.Models.Core.Device;
using Gas.Shared.Repository.Device;
using Gas.Shared.Repository.User;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Gas.Admin.Controllers
{
    
    public class DeviceController : Controller
    {
        private readonly DeviceRepository _deviceRepository;
        private readonly IMemoryCache _memoryCache;
        private readonly UserRepository _userRepostory;
        private readonly ILogger<DeviceController> _logger;
        private readonly DeviceHubWorker _deviceHubWorker;

        public DeviceController(
            DeviceRepository deviceRepository,
            DeviceHubWorker deviceHubWorker,
            IMemoryCache memoryCache,
            UserRepository userRepostory,
            ILogger<DeviceController> logger)
        {
            _memoryCache = memoryCache;
            _deviceRepository = deviceRepository;
            _userRepostory = userRepostory;
            _logger = logger;
            _deviceHubWorker = deviceHubWorker;
        }

        [Route("/SetData")]
        [HttpGet]
        public async Task<IActionResult> setData([FromQuery] DeviceDataVMModel model)
        {
            // var devices = _memoryCache.Get<IDictionary<string, DeviceCacheModel>>("devices");
            // if (devices == null)
            // {
            //     devices = new Dictionary<string, DeviceCacheModel>();
            // }
            // var setting = model.GetDeviceModel();
            // var device = devices[model.Id];
            // if (device == null)
            // {
            //     var current = new DeviceCacheModel();
            //     current.Key = model.Id;
            //     devices[model.Id] = current;
            // }
            // devices[model.Id].Timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            //
            // _memoryCache.Set("devices", devices);
            // return Ok();
            try
            {
                await _deviceHubWorker.DeviceConfigUpdated(model.Id, DateTime.Now);
                var current = _deviceRepository.GetByKey(model.Id);
                if (current != null)
                {
                    _logger.LogInformation(model.data);
                    var settings = model.GetDeviceModel();
                    current.DeviceConfig.dpdrac = settings.dpdrac;
                
                    current.DeviceConfig.dpdrac = settings.dpdrac;
                    current.DeviceConfig.dpgorcakic = settings.dpgorcakic;
                    current.DeviceConfig.dppastaci = settings.dppastaci;
                    current.DeviceConfig.flowhanac = settings.flowhanac;
                    current.DeviceConfig.flowauto = settings.flowauto;
                    current.DeviceConfig.flowmax = settings.flowmax;
                    current.DeviceConfig.flowpast = settings.flowpast;
                    current.DeviceConfig.flowproc = settings.flowproc;
                    current.DeviceConfig.flowsarqac = settings.flowsarqac;
                    current.DeviceConfig.kgorcakic =settings.kgorcakic;
                    current.DeviceConfig.pressgorcakic = settings.pressgorcakic;
                    current.DeviceConfig.presspastaci = settings.presspastaci;
                    current.DeviceConfig.onoff = settings.onoff;
                    current.DeviceConfig.selfonoff = settings.selfonoff;

                    _deviceRepository.UpdateDeviceConfig(current);
                }
                _logger.LogInformation(JsonConvert.SerializeObject(model));
                _logger.LogInformation(JsonConvert.SerializeObject(current));
                return await Task.Run(() => new JsonResult(new { }));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return await Task.Run(() => BadRequest());
            }
        }

        [HttpGet]
        [Route("/GetSettings/{key}")]
        public IActionResult getSettings(string key)
        {
            var current = _deviceRepository.GetByKey(key);
            var vm = new GetSettingsVMModel();
            if (current != null)
            {
                vm = new GetSettingsVMModel(current);
            }
            return new JsonResult(vm);
        }

        [AuthorizeUser((int)Modules.Device, new int[] { (int)DeviceModule.Index })]
        [Route("/Device")]
        [Route("/Device/Index")]
        [HttpGet]
        public async Task<IActionResult> Index(DevicePagingVm paging)
        {
            await _deviceHubWorker.DeviceConfigUpdated("s", DateTime.Now);
            var model = new DeviceVm();
            int UserId = Int32.Parse(HttpContext.User.Claims.FirstOrDefault().Value);
            var user = _userRepostory.getById(UserId);
            var filter = new DeviceFilter() {CurrentPage = paging.Page, PageSize = paging.PageSize};
            if (!user.UserRoles.Any(r => r.Role != null && r.Role.SystemRole))
            {
                filter.UserId = user.ID;
            }
            model.List = _deviceRepository.GetList(filter);
            return await Task.Run(() => View(model));
        }

        [AuthorizeUser((int)Modules.Device, new int[] { (int)DeviceModule.Edit })]
        [HttpGet]
        [Route("/Device/Add")]
        public IActionResult Add()
        {
            return View();
        }

        
        [AuthorizeUser((int)Modules.Device, new int[] { (int)DeviceModule.Edit })]
        [HttpPost]
        [Route("/Device/Add")]
        public IActionResult Add(DeviceAddPostVm model)
        {
            _deviceRepository.Add(model.GetDbModel());
            _deviceRepository.Save();
            return RedirectToAction("Index");
        }

        [AuthorizeUser((int)Modules.Device, new int[] { (int)DeviceModule.Edit })]
        [HttpGet]
        [Route("/Device/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var permission = _deviceRepository.Get(id);
            DeviceEditVm model = new DeviceEditVm(permission);

            model.Devices = _deviceRepository.GetList(new DeviceFilter(1, 100000)).Results;
            model.Users = _userRepostory.GetList(new DeviceFilter(1, 100000)).Results;
            return View(model);
        }

        
        [AuthorizeUser((int)Modules.Device, new int[] { (int)DeviceModule.Edit })]
        [HttpPost]
        [Route("/Device/Edit")]
        public IActionResult Edit(DeviceEditVm model)
        {
            var current = model.GetDbModel();
            _deviceRepository.Update(current);
            _deviceRepository.Save();
            return RedirectToAction("Index");
        }
        
        
        [AuthorizeUser((int)Modules.Device, new int[] { (int)DeviceModule.Edit })]
        [HttpPost]
        [Route("/Device/Delete")]
        public IActionResult Delete([FromBody] IEnumerable<int> model)
        {
            
            foreach (var item in model)
            {
                _deviceRepository.Delete(item);
            }
            _deviceRepository.Save();
            return new JsonResult(new {});
        }
        
        [AuthorizeUser((int)Modules.Device, new int[] { (int)DeviceModule.Edit })]
        [HttpPost]
        [Route("/Device/Deletes")]
        public IActionResult Deletes(DeleteItemsVm model)
        {
            foreach (var item in model.Items)
            {
                _deviceRepository.Delete(item);
            }
            _deviceRepository.Save();

            return Redirect(model.ReturnUrl);
        }
    }
}