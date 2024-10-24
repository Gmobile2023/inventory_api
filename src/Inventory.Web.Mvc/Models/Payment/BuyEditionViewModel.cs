using System.Collections.Generic;
using Inventory.Editions;
using Inventory.Editions.Dto;
using Inventory.MultiTenancy.Payments;
using Inventory.MultiTenancy.Payments.Dto;

namespace Inventory.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
