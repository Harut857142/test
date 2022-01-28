using System;

namespace Gas.Shared.Models.Core
{
    public class AuthorTranslation
    {
        public int ID { get; set; }
        public int? AuthorID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;
        

        public virtual Author Author { get; set; }
    }
}