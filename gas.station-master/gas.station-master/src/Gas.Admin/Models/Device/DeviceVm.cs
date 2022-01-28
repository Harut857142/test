using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Gas.Shared.Models.Core.Paging;
using Gas.Shared.Models.Core.Device;

namespace Gas.Admin.Models.Device
{
    public class DeviceVm
    {
        public string SearchType { get; set; }
        public int? Module { get; set; }
        public string ModuleName { get; set; }
        public int? Device { get; set; }
        public string DeviceName { get; set; }
        public string Description { get; set; }
        public DateTime? CreationDateFrom { get; set; }
        public DateTime? CreationDateTo { get; set; }
        public PagedResult<Shared.Models.Core.Device.Device> List { get; set; }
        public PagedResult<Shared.Models.Core.User.User> Users { get; set; }
        public bool IsEmpty()
        {
            return String.IsNullOrEmpty(SearchType);
        }
        
        public Shared.Models.Core.Device.Device ParentDevice { get; set; } 

        public void ClearFilters()
        {
            if (SearchType != "Module")
                Module = null;
            if (SearchType != "ModuleName")
                ModuleName = null;
            if (SearchType != "Device")
                Device = null;
            if (SearchType != "DeviceName")
                DeviceName = null;
            if (SearchType != "Description")
                Description = null;
            

            if (SearchType != "CreationDate")
            {
                CreationDateFrom = null;
                CreationDateTo = null;   
            }
        }
        public DeviceVm()
        {
            List = new PagedResult<Shared.Models.Core.Device.Device>();
        }
        public DeviceVm(PagedResult<Shared.Models.Core.Device.Device> list)
        {
            List = list;
        }

        public DeviceFilter GetFilter()
        {
            return new DeviceFilter()
            {
                SearchType = SearchType,
                Module = Module,
                ModuleName= ModuleName,
                Device= Device,
                DeviceName= DeviceName,
                Description= Description,
                CreationDateFrom = CreationDateFrom,
                CreationDateTo = CreationDateTo,
            };
            
        }

        public void FromFilter(DeviceFilter filter)
        {
            SearchType = filter.SearchType;
            Module = filter.Module;
            ModuleName = filter.ModuleName;
            Device = filter.Device;
            DeviceName = filter.DeviceName;
            Description = filter.Description;
            CreationDateFrom = filter.CreationDateFrom;
            CreationDateTo = filter.CreationDateTo;
        }
        
        public static List<string> ReadAsList(IFormFile file)
        {
//            var result = new StringBuilder();
            List<string> result = new List<string>();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    result.Add(reader.ReadLine()); 
            }
            return result;
        }
    }
}