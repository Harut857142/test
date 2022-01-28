using System;
using System.Collections.Generic;

namespace Gas.Shared.Models.Core
{
    public class BookLanguage 
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;

        public virtual List<BookLanguageTranslation> BookLanguageTranslations { get; set; } = new List<BookLanguageTranslation>();
        public virtual List<Book> Books { get; set; } = new List<Book>();
    }
}