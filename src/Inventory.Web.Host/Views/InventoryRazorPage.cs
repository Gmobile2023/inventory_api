using Abp.AspNetCore.Mvc.Views;

namespace Inventory.Web.Views
{
    public abstract class InventoryRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected InventoryRazorPage()
        {
            LocalizationSourceName = InventoryConsts.LocalizationSourceName;
        }
    }
}
