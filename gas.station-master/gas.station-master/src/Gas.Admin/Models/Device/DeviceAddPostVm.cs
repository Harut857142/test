using System.Collections.Generic;

namespace Gas.Admin.Models.Device
{
    public class DeviceAddPostVm : DeviceBaseVm
    {
        public IList<Shared.Models.Core.Device.Device> Devices { get; set; } =
            new List<Shared.Models.Core.Device.Device>();
        public Shared.Models.Core.Device.Device GetDbModel()
        {
            return new Shared.Models.Core.Device.Device()
            {
                Key = this.Key,
                ParentId = this.ParentId,
                UserId = this.UserId,
                DeviceName = this.DeviceName,
                Description = this.Description,
                DeviceConfig = this.DeviceConfig
            };
        }
    }
}