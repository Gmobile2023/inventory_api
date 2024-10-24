using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Inventory.Web.Areas.AppAreaName.Models.Layout;
using Inventory.Web.Session;
using Inventory.Web.Views;

namespace Inventory.Web.Areas.AppAreaName.Views.Shared.Themes.Theme4.Components.AppAreaNameTheme4Brand
{
    public class AppAreaNameTheme4BrandViewComponent : InventoryViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameTheme4BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
