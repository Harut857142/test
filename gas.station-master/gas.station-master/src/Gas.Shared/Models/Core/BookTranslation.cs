using System;

namespace Gas.Shared.Models.Core
{
    public class BookTranslation
    {
        public int ID { get; set; }
        public int? BookID { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Language { get; set; }
        public string LanguageName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;


        public virtual Book Book { get; set; }
    }
}