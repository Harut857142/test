using System;

namespace Gas.Shared.Models.Core
{
    public class ArticleTranslation
    {
        public int ID { get; set; }
        public int? ArticleID { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Content { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;
        

        public virtual Article Article { get; set; }
    }
}