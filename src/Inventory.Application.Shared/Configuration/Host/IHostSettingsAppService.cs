using System.Threading.Tasks;
using Abp.Application.Services;
using Inventory.Configuration.Host.Dto;

namespace Inventory.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
