

namespace Gas.Admin.Models.Device
{
    public class GetSettingsVMModel
    {
        public string id { get; set; }
        public float? flowhanac { get; set; }
        public float? flowmax { get; set; }
        public float? flowproc { get; set; }
        public float? dpgorcakic { get; set; }
        public float? kgorcakic { get; set; }
        public float? flowauto { get; set; }
        public float? pressgorcakic { get; set; }
        public bool? onoff { get; set; }
        public bool? flowAutoOnoff { get; set; }
        public float? masterFlowAuto { get; set; }
        public string date { get; set; }

        public GetSettingsVMModel()
        {
            
        }

        public GetSettingsVMModel(Shared.Models.Core.Device.Device device)
        {
            this.id = device.Key;
            this.flowhanac = device.DeviceConfig.flowhanacset;
            this.flowauto = 0;
            if (device.Parent != null && device.Parent.DeviceConfig != null &&
                device.Parent.DeviceConfig.flowpast != null && device.Parent.DeviceConfig.flowsarqac != null)
                this.flowauto = device.Parent.DeviceConfig.flowpast - device.Parent.DeviceConfig.flowsarqac;
            this.flowmax = device.DeviceConfig.flowmaxset;
            this.flowproc = device.DeviceConfig.flowprocset;
            this.dpgorcakic = device.DeviceConfig.dpgorcakicset;
            this.kgorcakic = device.DeviceConfig.kgorcakicset;
            this.pressgorcakic = device.DeviceConfig.pressgorcakicset;
            this.onoff = device.DeviceConfig.onoff;
            this.flowAutoOnoff = device.DeviceConfig.flowAutoOnoff;
            this.date = device.DeviceConfig.ModificationDate.ToString();

            if (false)
            {
            }
        }
    }
}
