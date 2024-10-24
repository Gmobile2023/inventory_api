using Abp.AspNetCore.Mvc.ViewComponents;

namespace Inventory.Web.Public.Views
{
    public abstract class InventoryViewComponent : AbpViewComponent
    {
        protected InventoryViewComponent()
        {
            LocalizationSourceName = InventoryConsts.LocalizationSourceName;
        }
    }
}