using System.Collections.Generic;

namespace AuthServer.Logging.Dto
{
    public class GetLatestWebLogsOutput
    {
        public List<string> LatestWebLogLines { get; set; }
    }
}
