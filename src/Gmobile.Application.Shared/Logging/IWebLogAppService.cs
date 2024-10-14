using Abp.Application.Services;
using Gmobile.Dto;
using Gmobile.Logging.Dto;

namespace Gmobile.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
