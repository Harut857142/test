using System.Collections.Generic;

namespace Gas.Admin.Models.NavigationMenuItem
{
    public class NavigationMenuItemEditVm : NavigationMenuItemBaseVm
    {
        public int Id { get; set; }
        public IEnumerable<Shared.Models.Core.NavigationMenuItem> NavigationMenuItems { get; set; } = new List<Shared.Models.Core.NavigationMenuItem>();

        public NavigationMenuItemEditVm()
        {
            
        }

        public NavigationMenuItemEditVm(Shared.Models.Core.NavigationMenuItem item)
        {
            this.NavigationMenuItem = item;
        }
        public Shared.Models.Core.NavigationMenuItem GetDbModel()
        {
            return new Shared.Models.Core.NavigationMenuItem()
            {
                ID = this.NavigationMenuItem.ID,
                NavigationMenuItemTranslations = this.NavigationMenuItem.NavigationMenuItemTranslations,
                IsActive = this.NavigationMenuItem.IsActive,
                Url = this.NavigationMenuItem.Url,
                Keyword = this.NavigationMenuItem.Keyword,
                Order = this.NavigationMenuItem.Order,
                Type = this.NavigationMenuItem.Type,
                ParentNavigationMenuItemID = this.NavigationMenuItem.ParentNavigationMenuItemID
            };
        }
    }
}