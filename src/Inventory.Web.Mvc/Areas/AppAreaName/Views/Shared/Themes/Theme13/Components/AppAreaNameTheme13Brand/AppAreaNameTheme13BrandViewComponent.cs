﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Inventory.Web.Areas.AppAreaName.Models.Layout;
using Inventory.Web.Session;
using Inventory.Web.Views;

namespace Inventory.Web.Areas.AppAreaName.Views.Shared.Themes.Theme13.Components.AppAreaNameTheme13Brand
{
    public class AppAreaNameTheme13BrandViewComponent : InventoryViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameTheme13BrandViewComponent(IPerRequestSessionCache sessionCache)
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
