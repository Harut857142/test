using System.Collections.Generic;

namespace Gas.Admin.Models.Review
{
    public class ReviewEditVm : ReviewBaseVm
    {
        public IEnumerable<int> NewBooks { get; set; } = new List<int>();
        public IEnumerable<Shared.Models.Core.Book> AllBooks { get; set; } = new List<Shared.Models.Core.Book>();
        public int Id { get; set; }

        public ReviewEditVm()
        {
            
        }

        public ReviewEditVm(Shared.Models.Core.Review item)
        {
            this.Review = item;
        }
        public Shared.Models.Core.Review GetDbModel()
        {
            return new Shared.Models.Core.Review()
            {
                ID = this.Review.ID,
                Language = this.Review.Language,
                ReviewTranslations = this.Review.ReviewTranslations,
                IsActive = this.Review.IsActive,
            };
        }
    }
}