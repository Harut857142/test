using System;

namespace Gas.Shared.Models.Core
{
    public class ReviewTranslation
    {
        public int ID { get; set; }
        public int? ReviewID { get; set; }
        public string SourceName { get; set; }
        public string SourceAuthor { get; set; }
        public string LongDescription { get; set; }
        public string Content { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;
        public virtual Review Review { get; set; }
    }
}