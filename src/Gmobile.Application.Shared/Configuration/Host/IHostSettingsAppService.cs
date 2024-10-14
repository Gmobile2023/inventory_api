using System.Threading.Tasks;
using Abp.Application.Services;
using Gmobile.Configuration.Host.Dto;

namespace Gmobile.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
