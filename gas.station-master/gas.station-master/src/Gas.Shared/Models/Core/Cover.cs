using System;
using System.Collections.Generic;

namespace Gas.Shared.Models.Core
{
    public class Cover
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;
        public virtual IEnumerable<CoverTranslation> CoverTranslations { get; set; } = new List<CoverTranslation>();
    }
}