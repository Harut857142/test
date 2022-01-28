namespace Gas.Admin.Models.Category
{
    public class CategoryAddPostVm : CategoryBaseVm
    {
        public CategoryAddPostVm()
        {
            
        }
        public CategoryAddPostVm(Shared.Models.Core.Category item)
        {
            this.Category = item;
        }
        public Shared.Models.Core.Category GetDbModel()
        {
            return new Shared.Models.Core.Category()
            {
                CategoryTranslations = this.Category.CategoryTranslations,
                IsActive = this.Category.IsActive,
                ParentCategoryID = this.Category.ParentCategoryID,
            };
        }
    }
}