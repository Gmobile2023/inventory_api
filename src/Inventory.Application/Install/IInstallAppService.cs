using System.Threading.Tasks;
using Abp.Application.Services;
using Inventory.Install.Dto;

namespace Inventory.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}