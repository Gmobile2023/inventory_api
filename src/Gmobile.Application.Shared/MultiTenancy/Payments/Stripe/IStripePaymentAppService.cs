using System.Threading.Tasks;
using Abp.Application.Services;
using Gmobile.MultiTenancy.Payments.Dto;
using Gmobile.MultiTenancy.Payments.Stripe.Dto;

namespace Gmobile.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();
        
        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}