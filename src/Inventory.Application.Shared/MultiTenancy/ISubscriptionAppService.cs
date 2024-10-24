using System.Threading.Tasks;
using Abp.Application.Services;

namespace Inventory.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
