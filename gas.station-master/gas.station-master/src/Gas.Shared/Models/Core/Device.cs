using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Gas.Shared.Models.Core.Device
{
    public class Device
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int? UserId { get; set; }
        public string Key { get; set; }
        public string DeviceName { get; set; }
        public string Description { get; set; }
        public DateTime? ModificationDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public virtual User.User User { get; set; }
        public bool Status { get; set; } = true;
        public virtual DeviceConfig DeviceConfig { get; set; } = new DeviceConfig();
        [JsonIgnore]
        public virtual Device Parent { get; set; }
    }
}