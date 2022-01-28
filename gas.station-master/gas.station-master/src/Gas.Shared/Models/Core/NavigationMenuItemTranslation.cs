using System;

namespace Gas.Shared.Models.Core
{
    public class NavigationMenuItemTranslation
    {
        public int ID { get; set; }
        public int? NavigationMenuItemID { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;
        

        public virtual NavigationMenuItem NavigationMenuItem { get; set; }
    }
}