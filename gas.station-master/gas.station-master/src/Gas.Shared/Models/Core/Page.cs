using System;
using System.Collections.Generic;

namespace Gas.Shared.Models.Core
{
    public class Page 
    {
        public int ID { get; set; }
        public string Identifier { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;

        public virtual List<PageTranslation> PageTranslations { get; set; } = new List<PageTranslation>();
    }
}