using System.Collections.Generic;

namespace Gas.Admin.Models.Device
{
    public class DeviceEditVm : DeviceBaseVm
    {
        public IList<Shared.Models.Core.Device.Device> Devices { get; set; } =
            new List<Shared.Models.Core.Device.Device>();
        public IList<Shared.Models.Core.User.User> Users { get; set; } =
            new List<Shared.Models.Core.User.User>();
        public int Id { get; set; }

        public DeviceEditVm()
        {
            
        }
        public DeviceEditVm(Shared.Models.Core.Device.Device permission)
        {
            this.Id = permission.Id;
            this.Key = permission.Key;
            this.UserId = permission.UserId;
            this.ParentId = permission.ParentId;
            this.DeviceName = permission.DeviceName;
            this.Description = permission.Description;
            this.DeviceConfig = permission.DeviceConfig;
        }
        public Shared.Models.Core.Device.Device GetDbModel()
        {
            return new Shared.Models.Core.Device.Device()
            {
                Id = this.Id,
                Key = this.Key,
                DeviceName = this.DeviceName,
                Description = this.Description,
                DeviceConfig = this.DeviceConfig,
                ParentId = this.ParentId,
                UserId = this.UserId
            };
        }
    }
}