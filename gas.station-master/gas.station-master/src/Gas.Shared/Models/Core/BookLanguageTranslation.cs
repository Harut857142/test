using System;

namespace Gas.Shared.Models.Core
{
    public class BookLanguageTranslation
    {
        public int ID { get; set; }
        public int? BookLanguageID { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;
        

        public virtual BookLanguage BookLanguage { get; set; }
    }
}