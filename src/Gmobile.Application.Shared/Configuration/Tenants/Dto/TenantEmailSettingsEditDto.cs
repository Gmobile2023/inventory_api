using Abp.Auditing;
using Gmobile.Configuration.Dto;

namespace Gmobile.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}