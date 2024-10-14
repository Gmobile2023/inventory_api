using System.Threading.Tasks;
using Abp.Webhooks;

namespace Gmobile.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
