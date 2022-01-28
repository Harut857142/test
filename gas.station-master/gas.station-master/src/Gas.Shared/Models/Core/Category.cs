using System;
using System.Collections.Generic;

namespace Gas.Shared.Models.Core
{
    public class Category
    {
        public int ID { get; set; }
        public int Level { get; set; }
        public int? ParentCategoryID { get; set; }
        public string BannerImage { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;

        public virtual Category ParentCategory { get; set; }
        public virtual List<Category> ChildrenCategory { get; set; } = new List<Category>();
        public virtual List<CategoryTranslation> CategoryTranslations { get; set; } = new List<CategoryTranslation>();
        public virtual List<BookCategory> BookCategories { get; set; } = new List<BookCategory>();
        public virtual List<CategoryPicture> CategoryPictures { get; set; } = new List<CategoryPicture>();
    }
}