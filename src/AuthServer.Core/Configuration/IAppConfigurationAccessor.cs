using Microsoft.Extensions.Configuration;

namespace AuthServer.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
