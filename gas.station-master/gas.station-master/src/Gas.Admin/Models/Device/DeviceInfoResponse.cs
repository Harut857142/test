using System;

namespace Gas.Admin.Models.Device
{
    public class DeviceInfoResponse
    {
        public string key { get; set; }
        public bool active { get; set; }
        public DateTime? date { get; set; }
        public float? flowpast { get; set; }
        public float? flowsarqac { get; set; }
        public float? dppastaci { get; set; }
        public float? presspastaci { get; set; }
    }
}