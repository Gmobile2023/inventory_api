﻿using Abp.Application.Navigation;

namespace Inventory.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameMenu
{
    public class UserMenuItemViewModel
    {
        public UserMenuItem MenuItem { get; set; }

        public string CurrentPageName { get; set; }

        public int MenuItemIndex { get; set; }

        public int ItemDepth { get; set; }

        public bool RootLevel { get; set; }
        
        public bool IsTabMenuUsed { get; set; }
        
        public bool IconMenu { get; set; }
    }
}
