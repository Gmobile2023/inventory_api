using System.Threading.Tasks;
using Gmobile.Authorization.Users;

namespace Gmobile.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
