using System.Collections.Generic;

namespace Gas.Shared.Models.Core
{
    public class ArticlePicture
    {
        public int ID { get; set; }
        public string PictureUrl { get; set; }
        public int? ArticleID { get; set; }
        public bool IsActive { get; set; }

        public virtual Article Article { get; set; }
    }
}