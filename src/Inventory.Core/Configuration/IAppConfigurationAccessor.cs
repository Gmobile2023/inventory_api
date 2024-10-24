using Microsoft.Extensions.Configuration;

namespace Inventory.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
