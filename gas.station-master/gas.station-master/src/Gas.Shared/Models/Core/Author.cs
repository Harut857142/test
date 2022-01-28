using System;
using System.Collections.Generic;

namespace Gas.Shared.Models.Core
{
    public class Author
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? DeadYear { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;

        public virtual IEnumerable<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();

        public virtual IEnumerable<AuthorTranslation> AuthorTranslations { get; set; } = new List<AuthorTranslation>();
        public virtual List<AuthorPicture> AuthorPictures { get; set; } = new List<AuthorPicture>();
    }
}