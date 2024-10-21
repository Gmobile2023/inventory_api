using System.Threading.Tasks;
using AuthServer.Authorization.Users;

namespace AuthServer.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
