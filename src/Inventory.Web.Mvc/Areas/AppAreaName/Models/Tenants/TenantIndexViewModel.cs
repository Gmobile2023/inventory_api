using System.Collections.Generic;
using Inventory.Editions.Dto;

namespace Inventory.Web.Areas.AppAreaName.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}