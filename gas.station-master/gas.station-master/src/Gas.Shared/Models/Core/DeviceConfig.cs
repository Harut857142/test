using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Gas.Shared.Models.Core
{
    public class DeviceConfig
    {
        public int Id { get; set; }
        
        public int DeviceId { get; set; }
        
        public float? flowauto { get; set; }
        public float? dppastaci { get; set; }
        public float? dpdrac { get; set; }
        public float? dpgorcakic { get; set; }
        public float? flowpast { get; set; }
        public float? flowsarqac { get; set; }
        public float? flowhanac { get; set; }
        public float? kgorcakic { get; set; }
        
        public float? flowhanacset { get; set; }
        public float? pressgorcakicset { get; set; }
        public float? kgorcakicset { get; set; }
        public float? dpgorcakicset { get; set; }
        public float? flowmaxset { get; set; }
        public float? flowprocset { get; set; }
        
        public float? selfonoff { get; set; }
        public float? flowmax { get; set; }
        public float? flowproc { get; set; }
        public float? presspastaci { get; set; }
        public float? pressgorcakic { get; set; }
        public bool? onoff { get; set; }
        public bool? flowAutoOnoff { get; set; }
        
        public DateTime? ModificationDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool Status { get; set; } = true;
        
        [JsonIgnore]
        public virtual Device.Device Device { get; set; }
    }
}