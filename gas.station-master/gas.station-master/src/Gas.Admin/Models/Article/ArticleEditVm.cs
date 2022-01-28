using System.Collections.Generic;

namespace Gas.Admin.Models.Article
{
    public class ArticleEditVm : ArticleBaseVm
    {
        public IEnumerable<int> NewBooks { get; set; } = new List<int>();
        public IEnumerable<Shared.Models.Core.Book> AllBooks { get; set; } = new List<Shared.Models.Core.Book>();
        public int Id { get; set; }

        public ArticleEditVm()
        {
            
        }

        public ArticleEditVm(Shared.Models.Core.Article item)
        {
            this.Article = item;
        }
        public Shared.Models.Core.Article GetDbModel()
        {
            return new Shared.Models.Core.Article()
            {
                ID = this.Article.ID,
                Language = this.Article.Language,
                ArticleTranslations = this.Article.ArticleTranslations,
                IsActive = this.Article.IsActive,
            };
        }
    }
}