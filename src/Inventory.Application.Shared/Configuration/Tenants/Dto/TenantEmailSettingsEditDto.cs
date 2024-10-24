using Abp.Auditing;
using Inventory.Configuration.Dto;

namespace Inventory.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}