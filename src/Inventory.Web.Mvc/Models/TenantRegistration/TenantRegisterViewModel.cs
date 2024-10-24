using Inventory.Editions;
using Inventory.Editions.Dto;
using Inventory.MultiTenancy.Payments;
using Inventory.Security;
using Inventory.MultiTenancy.Payments.Dto;

namespace Inventory.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
