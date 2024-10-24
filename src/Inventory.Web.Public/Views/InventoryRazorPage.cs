using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Inventory.Web.Public.Views
{
    public abstract class InventoryRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected InventoryRazorPage()
        {
            LocalizationSourceName = InventoryConsts.LocalizationSourceName;
        }
    }
}
