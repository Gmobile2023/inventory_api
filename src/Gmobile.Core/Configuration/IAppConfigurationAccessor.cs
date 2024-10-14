using Microsoft.Extensions.Configuration;

namespace Gmobile.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
