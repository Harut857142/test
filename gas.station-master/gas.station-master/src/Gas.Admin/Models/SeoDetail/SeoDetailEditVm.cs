using System.Collections.Generic;

namespace Gas.Admin.Models.SeoDetail
{
    public class SeoDetailEditVm : SeoDetailBaseVm
    {
        public IEnumerable<int> NewBooks { get; set; } = new List<int>();
        public IEnumerable<Shared.Models.Core.Book> AllBooks { get; set; } = new List<Shared.Models.Core.Book>();
        public int Id { get; set; }

        public SeoDetailEditVm()
        {
            
        }

        public SeoDetailEditVm(Shared.Models.Core.SeoDetail item)
        {
            this.SeoDetail = item;
        }
        public Shared.Models.Core.SeoDetail GetDbModel()
        {
            return new Shared.Models.Core.SeoDetail()
            {
                ID = this.SeoDetail.ID,
                Language = this.SeoDetail.Language,
                Type = this.SeoDetail.Type,
                Url = this.SeoDetail.Url,
                Robots = this.SeoDetail.Robots,
                ImageUrl = this.SeoDetail.ImageUrl,
                SeoDetailTranslations = this.SeoDetail.SeoDetailTranslations,
                IsActive = this.SeoDetail.IsActive,
            };
        }
    }
}