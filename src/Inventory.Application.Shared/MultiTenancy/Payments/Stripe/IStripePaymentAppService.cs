using System.Threading.Tasks;
using Abp.Application.Services;
using Inventory.MultiTenancy.Payments.Dto;
using Inventory.MultiTenancy.Payments.Stripe.Dto;

namespace Inventory.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}