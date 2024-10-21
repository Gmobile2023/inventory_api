using Abp.Events.Bus;

namespace AuthServer.MultiTenancy.Subscription
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}