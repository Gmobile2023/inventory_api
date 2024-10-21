using System.Threading.Tasks;
using Abp.Webhooks;

namespace AuthServer.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
