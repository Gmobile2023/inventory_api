﻿using System.Collections.Generic;
using Abp.Localization;
using Inventory.Install.Dto;

namespace Inventory.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
