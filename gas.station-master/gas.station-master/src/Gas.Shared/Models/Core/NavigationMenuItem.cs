using System;
using System.Collections.Generic;

namespace Gas.Shared.Models.Core
{
    public class NavigationMenuItem 
    {
        public int ID { get; set; }
        public int? ParentNavigationMenuItemID { get; set; }
        public string Url { get; set; }
        public string Keyword { get; set; }
        public bool IsActive { get; set; }
        public int Type { get; set; }
        public int Order { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;

        public NavigationMenuItem()
        {
            
        }

        public virtual NavigationMenuItem ParentNavigationMenuItem { get; set; }
        public virtual List<NavigationMenuItem > ChildrenNavigationMenuItem  { get; set; } = new List<NavigationMenuItem >();
        public virtual List<NavigationMenuItemTranslation> NavigationMenuItemTranslations { get; set; } = new List<NavigationMenuItemTranslation>();
    }
}