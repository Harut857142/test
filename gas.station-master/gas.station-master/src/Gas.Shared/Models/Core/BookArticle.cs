namespace Gas.Shared.Models.Core
{
    public class BookArticle
    {
        public int ID { get; set; }
        public int? BookID { get; set; }
        public int? ArticleID { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }

        public virtual Book Book { get; set; }
        public virtual Article Article { get; set; }
    }
}