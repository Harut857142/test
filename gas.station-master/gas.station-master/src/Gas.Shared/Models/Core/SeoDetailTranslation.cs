using System;

namespace Gas.Shared.Models.Core
{
    public class SeoDetailTranslation
    {
        public int ID { get; set; }
        public int? SeoDetailID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;
        

        public virtual SeoDetail SeoDetail { get; set; }
    }
}