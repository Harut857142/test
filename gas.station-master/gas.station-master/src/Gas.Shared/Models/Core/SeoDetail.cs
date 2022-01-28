using System;
using System.Collections.Generic;

namespace Gas.Shared.Models.Core
{
    public class SeoDetail
    {
        public int ID { get; set; }
        public string Url { get; set; }
        public string Robots { get; set; }
        public string ImageUrl { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;
        public virtual List<SeoDetailTranslation> SeoDetailTranslations { get; set; } = new List<SeoDetailTranslation>();
    }
}