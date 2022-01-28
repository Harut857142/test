using System;
using System.Collections.Generic;

namespace Gas.Shared.Models.Core
{
    public class Article
    {
        public int ID { get; set; }
        public string CoverImage { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;

        public virtual List<BookArticle> BookArticles { get; set; } = new List<BookArticle>();

        public virtual List<ArticleTranslation> ArticleTranslations { get; set; } = new List<ArticleTranslation>();
        public virtual List<ArticlePicture> ArticlePictures { get; set; } = new List<ArticlePicture>();
    }
}