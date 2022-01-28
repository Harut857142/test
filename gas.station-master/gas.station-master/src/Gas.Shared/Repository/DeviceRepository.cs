using System;
using System.Linq;
using Gas.Shared.DbProvider;
using Gas.Shared.Models.Core.Paging;
using Gas.Shared.Models.Core.Device;
using Gas.Shared.Repository.Shared;
using Microsoft.EntityFrameworkCore;

namespace Gas.Shared.Repository.Device
{
    public class DeviceRepository
    {
        private readonly Context _context;

        public DeviceRepository(Context context)
        {
            _context = context;
        }
        
        public Models.Core.Device.Device Get(int id)
        {
            return _context.Devices.Where(r => (r.Id == id && r.Status))
                .Include(r => r.User)
                .Include(r => r.DeviceConfig)
                .Include(r => r.Parent)
                .ThenInclude(r => r.DeviceConfig)
                .Select(r => r).FirstOrDefault();
        }
        
        public Models.Core.Device.Device GetByKey(string key)
        {
            return _context.Devices.Where(r => (r.Key == key && r.Status))
                .Include(r => r.User)
                .Include(r => r.DeviceConfig)
                .Include(r => r.Parent)
                .ThenInclude(r => r.DeviceConfig)
                .Select(r => r).FirstOrDefault();
        }

        public PagedResult<Models.Core.Device.Device> GetList(DeviceFilter filter)
        {
            return _context.Devices.Where(r => (r.Status) && (filter.UserId == null || r.UserId == filter.UserId)).Include(r => r.DeviceConfig)
                .Select(customerInformation => customerInformation).AsQueryable().GetPaged(filter.CurrentPage, filter.PageSize);
        }

        public Models.Core.Device.Device Add(Models.Core.Device.Device model)
        {
            model.CreationDate = DateTime.UtcNow;
            model.Status = true;
            _context.Devices.Add(model);
            Save();
            return model;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public Models.Core.Device.Device UpdateDeviceConfig(Models.Core.Device.Device model)
        {
            var current = this.Get(model.Id);
            
            if (!String.IsNullOrEmpty(model.Key))
                current.Key = model.Key;
            if (!String.IsNullOrEmpty(model.Description))
                current.Description = model.Description;
            if (!String.IsNullOrEmpty(model.DeviceName))
                current.DeviceName = model.DeviceName;
            if (model.DeviceConfig.dpdrac != null)
                current.DeviceConfig.dpdrac = model.DeviceConfig.dpdrac;
            if (model.DeviceConfig.dpgorcakic != null)
                current.DeviceConfig.dpgorcakic = model.DeviceConfig.dpgorcakic;
            if (model.DeviceConfig.dppastaci != null)
                current.DeviceConfig.dppastaci = model.DeviceConfig.dppastaci;
            if (model.DeviceConfig.flowhanac != null)
                current.DeviceConfig.flowhanac = model.DeviceConfig.flowhanac;
            if (model.DeviceConfig.flowhanacset != null)
            {
                current.DeviceConfig.flowhanacset = model.DeviceConfig.flowhanacset;
            }
            if (model.DeviceConfig.pressgorcakicset != null)
            {
                current.DeviceConfig.pressgorcakicset = model.DeviceConfig.pressgorcakicset;
            }
            if (model.DeviceConfig.kgorcakicset != null)
            {
                current.DeviceConfig.kgorcakicset = model.DeviceConfig.kgorcakicset;
            }
            if (model.DeviceConfig.dpgorcakicset != null)
            {
                current.DeviceConfig.dpgorcakicset = model.DeviceConfig.dpgorcakicset;
            }
            if (model.DeviceConfig.flowmaxset != null)
            {
                current.DeviceConfig.flowmaxset = model.DeviceConfig.flowmaxset;
            }
            if (model.DeviceConfig.flowprocset != null)
            {
                current.DeviceConfig.flowprocset = model.DeviceConfig.flowprocset;
            }
            if (model.DeviceConfig.flowauto != null)
                current.DeviceConfig.flowauto = model.DeviceConfig.flowauto;
            if (model.DeviceConfig.flowmax != null)
                current.DeviceConfig.flowmax = model.DeviceConfig.flowmax;
            if (model.DeviceConfig.flowpast != null)
                current.DeviceConfig.flowpast = model.DeviceConfig.flowpast;
            if (model.DeviceConfig.flowproc != null)
                current.DeviceConfig.flowproc = model.DeviceConfig.flowproc;
            if (model.DeviceConfig.flowsarqac != null)
                current.DeviceConfig.flowsarqac = model.DeviceConfig.flowsarqac;
            if (model.DeviceConfig.flowAutoOnoff != null)
                current.DeviceConfig.flowAutoOnoff = model.DeviceConfig.flowAutoOnoff;
            if (model.DeviceConfig.kgorcakic != null)
                current.DeviceConfig.kgorcakic = model.DeviceConfig.kgorcakic;
            if (model.DeviceConfig.pressgorcakic != null)
                current.DeviceConfig.pressgorcakic = model.DeviceConfig.pressgorcakic;
            if (model.DeviceConfig.presspastaci != null)
                current.DeviceConfig.presspastaci = model.DeviceConfig.presspastaci;
            if (model.DeviceConfig.onoff != null)
                current.DeviceConfig.onoff = model.DeviceConfig.onoff;
            if (model.DeviceConfig.selfonoff != null)
                current.DeviceConfig.selfonoff = model.DeviceConfig.selfonoff;
            if (current.CreationDate == null)
            {
                current.CreationDate = new DateTime();
            }
            current.DeviceConfig.ModificationDate = DateTime.Now;
            current.ModificationDate = DateTime.Now;
            _context.Devices.Update(current);
            _context.SaveChanges();
            _context.Entry(current).Reload();
            return model;
        }
        public Models.Core.Device.Device Update(Models.Core.Device.Device model)
        {
            var current = this.Get(model.Id);
            
            if (!String.IsNullOrEmpty(model.Key))
                current.Key = model.Key;
            if (!String.IsNullOrEmpty(model.Description))
                current.Description = model.Description;
            if (!String.IsNullOrEmpty(model.DeviceName))
                current.DeviceName = model.DeviceName;
            if (model.DeviceConfig.dpdrac != null)
                current.DeviceConfig.dpdrac = model.DeviceConfig.dpdrac;
            current.ParentId = model.ParentId;
            current.UserId = model.UserId;
            if (model.DeviceConfig.dpgorcakic != null)
                current.DeviceConfig.dpgorcakic = model.DeviceConfig.dpgorcakic;
            if (model.DeviceConfig.dppastaci != null)
                current.DeviceConfig.dppastaci = model.DeviceConfig.dppastaci;
            if (model.DeviceConfig.flowhanac != null)
                current.DeviceConfig.flowhanac = model.DeviceConfig.flowhanac;
            if (model.DeviceConfig.flowhanacset != null)
            {
                current.DeviceConfig.flowhanacset = model.DeviceConfig.flowhanacset;
            }
            if (model.DeviceConfig.pressgorcakicset != null)
            {
                current.DeviceConfig.pressgorcakicset = model.DeviceConfig.pressgorcakicset;
            }
            if (model.DeviceConfig.kgorcakicset != null)
            {
                current.DeviceConfig.kgorcakicset = model.DeviceConfig.kgorcakicset;
            }
            if (model.DeviceConfig.dpgorcakicset != null)
            {
                current.DeviceConfig.dpgorcakicset = model.DeviceConfig.dpgorcakicset;
            }
            if (model.DeviceConfig.flowmaxset != null)
            {
                current.DeviceConfig.flowmaxset = model.DeviceConfig.flowmaxset;
            }
            if (model.DeviceConfig.flowprocset != null)
            {
                current.DeviceConfig.flowprocset = model.DeviceConfig.flowprocset;
            }
            if (model.DeviceConfig.flowauto != null)
                current.DeviceConfig.flowauto = model.DeviceConfig.flowauto;
            if (model.DeviceConfig.flowmax != null)
                current.DeviceConfig.flowmax = model.DeviceConfig.flowmax;
            if (model.DeviceConfig.flowpast != null)
                current.DeviceConfig.flowpast = model.DeviceConfig.flowpast;
            if (model.DeviceConfig.flowproc != null)
                current.DeviceConfig.flowproc = model.DeviceConfig.flowproc;
            if (model.DeviceConfig.flowsarqac != null)
                current.DeviceConfig.flowsarqac = model.DeviceConfig.flowsarqac;
            if (model.DeviceConfig.flowAutoOnoff != null)
                current.DeviceConfig.flowAutoOnoff = model.DeviceConfig.flowAutoOnoff;
            if (model.DeviceConfig.kgorcakic != null)
                current.DeviceConfig.kgorcakic = model.DeviceConfig.kgorcakic;
            if (model.DeviceConfig.pressgorcakic != null)
                current.DeviceConfig.pressgorcakic = model.DeviceConfig.pressgorcakic;
            if (model.DeviceConfig.presspastaci != null)
                current.DeviceConfig.presspastaci = model.DeviceConfig.presspastaci;
            if (model.DeviceConfig.onoff != null)
                current.DeviceConfig.onoff = model.DeviceConfig.onoff;
            if (model.DeviceConfig.selfonoff != null)
                current.DeviceConfig.selfonoff = model.DeviceConfig.selfonoff;
            if (current.CreationDate == null)
            {
                current.CreationDate = new DateTime();
            }

            if (model.UserId != null)
            {
                current.UserId = model.UserId;
            }
            current.DeviceConfig.ModificationDate = DateTime.Now;
            current.ModificationDate = DateTime.Now;
            _context.Devices.Update(current);
            _context.SaveChanges();
            _context.Entry(current).Reload();
            return model;
        }

        public bool Update(int id, int? module, string moduleName, int? permission, string permissionName, string description)
        {

            var item = _context.Devices.Where(
                r => r.Status
                     && r.Id == id).FirstOrDefault();
            item.DeviceName = permissionName == null ? item.DeviceName : permissionName;
            item.Description = description == null ? item.Description : description;
            _context.Devices.Update(item);
            _context.SaveChanges();
            return true;
        }

        public void Delete(int id)
        {
            var item = _context.Devices.Where(
                r => r.Status
                     && r.Id == id).FirstOrDefault();
            item.Status = false;
            _context.Devices.Update(item);
            _context.SaveChanges();
        }
    }
}