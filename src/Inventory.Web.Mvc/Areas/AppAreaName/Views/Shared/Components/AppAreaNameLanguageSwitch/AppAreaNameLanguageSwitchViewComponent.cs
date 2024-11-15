﻿using System.Linq;
using System.Threading.Tasks;
using Abp.Localization;
using Microsoft.AspNetCore.Mvc;
using Inventory.Web.Areas.AppAreaName.Models.Layout;
using Inventory.Web.Views;

namespace Inventory.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameLanguageSwitch
{
    public class AppAreaNameLanguageSwitchViewComponent : InventoryViewComponent
    {
        private readonly ILanguageManager _languageManager;

        public AppAreaNameLanguageSwitchViewComponent(ILanguageManager languageManager)
        {
            _languageManager = languageManager;
        }

        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            var model = new LanguageSwitchViewModel
            {
                Languages = _languageManager.GetActiveLanguages().ToList(),
                CurrentLanguage = _languageManager.CurrentLanguage,
                CssClass = cssClass
            };
            
            return Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
