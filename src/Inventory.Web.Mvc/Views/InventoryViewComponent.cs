using Abp.AspNetCore.Mvc.ViewComponents;

namespace Inventory.Web.Views
{
    public abstract class InventoryViewComponent : AbpViewComponent
    {
        protected InventoryViewComponent()
        {
            LocalizationSourceName = InventoryConsts.LocalizationSourceName;
        }
    }
}