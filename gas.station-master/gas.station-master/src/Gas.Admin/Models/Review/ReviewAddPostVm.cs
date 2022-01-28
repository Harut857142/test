using System.Collections.Generic;

namespace Gas.Admin.Models.Review
{
    public class ReviewAddPostVm : ReviewBaseVm
    {
        public IEnumerable<int> NewBooks { get; set; } = new List<int>();
        public IEnumerable<Shared.Models.Core.Book> AllBooks { get; set; } = new List<Shared.Models.Core.Book>();
        public ReviewAddPostVm()
        {
            
        }
        public ReviewAddPostVm(Shared.Models.Core.Review item)
        {
            this.Review = item;
        }
        public Shared.Models.Core.Review GetDbModel()
        {
            return new Shared.Models.Core.Review()
            {
                Language = this.Review.Language,
                IsActive = this.Review.IsActive,
                ReviewTranslations = this.Review.ReviewTranslations
            };
        }
    }
}