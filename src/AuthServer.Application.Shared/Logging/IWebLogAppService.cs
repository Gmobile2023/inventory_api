using Abp.Application.Services;
using AuthServer.Dto;
using AuthServer.Logging.Dto;

namespace AuthServer.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
