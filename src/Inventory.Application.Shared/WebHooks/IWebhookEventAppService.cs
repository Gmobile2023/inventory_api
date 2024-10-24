using System.Threading.Tasks;
using Abp.Webhooks;

namespace Inventory.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
