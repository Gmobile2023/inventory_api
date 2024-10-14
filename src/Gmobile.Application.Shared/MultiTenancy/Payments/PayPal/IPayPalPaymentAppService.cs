using System.Threading.Tasks;
using Abp.Application.Services;
using Gmobile.MultiTenancy.Payments.PayPal.Dto;

namespace Gmobile.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
