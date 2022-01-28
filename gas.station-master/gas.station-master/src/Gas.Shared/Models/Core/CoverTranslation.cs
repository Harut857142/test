using System;

namespace Gas.Shared.Models.Core
{
    public class CoverTranslation
    {
        public int ID { get; set; }
        public int? CoverID { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;
        

        public virtual Cover Cover { get; set; }
    }
}