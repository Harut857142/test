using Gas.Shared.Models.Core;

namespace Gas.Admin.Models.Device
{
    public class DeviceBaseVm
    {
        public string Key { get; set; }
        public string DeviceName { get; set; }
        public string Description { get; set; }
        public DeviceConfig DeviceConfig { get; set; }
        public Shared.Models.Core.Device.Device Parent { get; set; }
        public int? ParentId { get; set; }
        public int? UserId { get; set; }
    }
}