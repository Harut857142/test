using Newtonsoft.Json;

namespace Gas.Admin.Models.Device
{
    public class DeviceDataVMModel
    {
        public string Id { get; set; }
        public string data { get; set; }

        public SetSettingsVMModel GetDeviceModel()
        {
            return JsonConvert.DeserializeObject<SetSettingsVMModel>(this.data);
        }
    }
}