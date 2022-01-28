namespace Gas.Admin.Models.Page
{
    public class PageAddPostVm : PageBaseVm
    {
        public PageAddPostVm()
        {
            
        }
        public PageAddPostVm(Shared.Models.Core.Page item)
        {
            this.Page = item;
        }
        public Shared.Models.Core.Page GetDbModel()
        {
            return new Shared.Models.Core.Page()
            {
                PageTranslations = this.Page.PageTranslations,
                IsActive = this.Page.IsActive,
                Identifier = this.Page.Identifier
            };
        }
    }
}