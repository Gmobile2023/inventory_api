using Abp.Auditing;
using AuthServer.Configuration.Dto;

namespace AuthServer.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}