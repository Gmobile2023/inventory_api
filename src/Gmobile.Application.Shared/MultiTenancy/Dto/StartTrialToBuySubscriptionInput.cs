using Gmobile.MultiTenancy.Payments;

namespace Gmobile.MultiTenancy.Dto
{
    public class StartTrialToBuySubscriptionInput
    {
        public PaymentPeriodType PaymentPeriodType { get; set; }
        
        public string SuccessUrl { get; set; }

        public string ErrorUrl { get; set; }
    }
}