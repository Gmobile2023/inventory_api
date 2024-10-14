using System.Threading.Tasks;
using Abp.Application.Services;
using Gmobile.Install.Dto;

namespace Gmobile.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}