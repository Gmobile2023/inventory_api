using System.Threading.Tasks;
using Abp.Application.Services;
using AuthServer.Configuration.Host.Dto;

namespace AuthServer.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
