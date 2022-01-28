using System;

namespace Gas.Shared.Models.Core
{
    public class CategoryTranslation
    {
        public int ID { get; set; }
        public int? CategoryID { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;
        

        public virtual Category Category { get; set; }
    }
}