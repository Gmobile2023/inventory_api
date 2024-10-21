using System.Threading.Tasks;
using Abp.Application.Services;
using AuthServer.Install.Dto;

namespace AuthServer.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}