using System.Collections.Generic;

namespace Gas.Admin.Models.Page
{
    public class PageEditVm : PageBaseVm
    {
        public int Id { get; set; }
        public IEnumerable<Shared.Models.Core.Page> Pages { get; set; } = new List<Shared.Models.Core.Page>();

        public PageEditVm()
        {
            
        }

        public PageEditVm(Shared.Models.Core.Page item)
        {
            this.Page = item;
        }
        public Shared.Models.Core.Page GetDbModel()
        {
            return new Shared.Models.Core.Page()
            {
                ID = this.Page.ID,
                PageTranslations = this.Page.PageTranslations,
                IsActive = this.Page.IsActive,
                Identifier = this.Page.Identifier,
            };
        }
    }
}