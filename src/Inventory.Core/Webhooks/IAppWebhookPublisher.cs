using System.Threading.Tasks;
using Inventory.Authorization.Users;

namespace Inventory.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
