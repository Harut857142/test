using System.Collections.Generic;

namespace Gas.Admin.Models.Category
{
    public class CategoryEditVm : CategoryBaseVm
    {
        public int Id { get; set; }
        public IEnumerable<Shared.Models.Core.Category> Categories { get; set; } = new List<Shared.Models.Core.Category>();

        public CategoryEditVm()
        {
            
        }

        public CategoryEditVm(Shared.Models.Core.Category item)
        {
            this.Category = item;
        }
        public Shared.Models.Core.Category GetDbModel()
        {
            return new Shared.Models.Core.Category()
            {
                ID = this.Category.ID,
                CategoryTranslations = this.Category.CategoryTranslations,
                IsActive = this.Category.IsActive,
                ParentCategoryID = this.Category.ParentCategoryID
            };
        }
    }
}