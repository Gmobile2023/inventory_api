﻿using System.Collections.Generic;
using Inventory.Organizations.Dto;
using Inventory.Web.Areas.AppAreaName.Models.Common;

namespace Inventory.Web.Areas.AppAreaName.Models.OrganizationUnits
{
    public class OrganizationUnitLookupTableModel : IOrganizationUnitsEditViewModel
    {
        public List<OrganizationUnitDto> AllOrganizationUnits { get; set; }
        
        public List<string> MemberedOrganizationUnits { get; set; }

        public OrganizationUnitLookupTableModel()
        {
            AllOrganizationUnits = new List<OrganizationUnitDto>();
            MemberedOrganizationUnits = new List<string>();
        }
    }
}