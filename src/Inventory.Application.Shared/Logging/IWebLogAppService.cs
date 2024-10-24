using Abp.Application.Services;
using Inventory.Dto;
using Inventory.Logging.Dto;

namespace Inventory.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
