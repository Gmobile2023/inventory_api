using System.Threading.Tasks;
using Abp.Application.Services;
using AuthServer.Configuration.Tenants.Dto;

namespace AuthServer.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearDarkLogo();
        
        Task ClearDarkLogoMinimal();

        Task ClearLightLogo();
        
        Task ClearLightLogoMinimal();

        Task ClearCustomCss();
    }
}
