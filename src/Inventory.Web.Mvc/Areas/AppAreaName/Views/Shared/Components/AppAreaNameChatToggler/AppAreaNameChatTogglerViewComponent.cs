using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Inventory.Web.Areas.AppAreaName.Models.Layout;
using Inventory.Web.Views;

namespace Inventory.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameChatToggler
{
    public class AppAreaNameChatTogglerViewComponent : InventoryViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, string iconClass = "flaticon-chat-2 fs-2")
        {
            return Task.FromResult<IViewComponentResult>(View(new ChatTogglerViewModel
            {
                CssClass = cssClass,
                IconClass = iconClass
            }));
        }
    }
}
