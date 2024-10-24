using Abp.AutoMapper;
using Inventory.MultiTenancy;
using Inventory.MultiTenancy.Dto;
using Inventory.Web.Areas.AppAreaName.Models.Common;

namespace Inventory.Web.Areas.AppAreaName.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}