using System.Collections.Generic;

namespace Gas.Admin.Models.Article
{
    public class ArticleAddPostVm : ArticleBaseVm
    {
        public IEnumerable<int> NewBooks { get; set; } = new List<int>();
        public IEnumerable<Shared.Models.Core.Book> AllBooks { get; set; } = new List<Shared.Models.Core.Book>();
        public ArticleAddPostVm()
        {
            
        }
        public ArticleAddPostVm(Shared.Models.Core.Article item)
        {
            this.Article = item;
        }
        public Shared.Models.Core.Article GetDbModel()
        {
            return new Shared.Models.Core.Article()
            {
                Language = this.Article.Language,
                IsActive = this.Article.IsActive,
                ArticleTranslations = this.Article.ArticleTranslations
            };
        }
    }
}