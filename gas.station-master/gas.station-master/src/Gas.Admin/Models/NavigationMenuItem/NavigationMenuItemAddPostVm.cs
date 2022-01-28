namespace Gas.Admin.Models.NavigationMenuItem
{
    public class NavigationMenuItemAddPostVm : NavigationMenuItemBaseVm
    {
        public NavigationMenuItemAddPostVm()
        {
            
        }
        public NavigationMenuItemAddPostVm(Shared.Models.Core.NavigationMenuItem item)
        {
            this.NavigationMenuItem = item;
        }
        public Shared.Models.Core.NavigationMenuItem GetDbModel()
        {
            return new Shared.Models.Core.NavigationMenuItem()
            {
                NavigationMenuItemTranslations = this.NavigationMenuItem.NavigationMenuItemTranslations,
                IsActive = this.NavigationMenuItem.IsActive,
                Url = this.NavigationMenuItem.Url,
                Keyword = this.NavigationMenuItem.Keyword,
                Order = this.NavigationMenuItem.Order,
                Type = this.NavigationMenuItem.Type,
                ParentNavigationMenuItemID = this.NavigationMenuItem.ParentNavigationMenuItemID,
            };
        }
    }
}