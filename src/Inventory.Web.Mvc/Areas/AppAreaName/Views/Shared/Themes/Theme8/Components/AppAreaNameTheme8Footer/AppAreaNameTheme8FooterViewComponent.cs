﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Inventory.Web.Areas.AppAreaName.Models.Layout;
using Inventory.Web.Session;
using Inventory.Web.Views;

namespace Inventory.Web.Areas.AppAreaName.Views.Shared.Themes.Theme8.Components.AppAreaNameTheme8Footer
{
    public class AppAreaNameTheme8FooterViewComponent : InventoryViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameTheme8FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
