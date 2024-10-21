using System.Threading.Tasks;
using Abp.Application.Services;
using AuthServer.MultiTenancy.Payments.Dto;
using AuthServer.MultiTenancy.Payments.Stripe.Dto;

namespace AuthServer.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();
        
        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}