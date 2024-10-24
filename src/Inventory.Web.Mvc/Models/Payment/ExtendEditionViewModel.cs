using System.Collections.Generic;
using Inventory.Editions.Dto;
using Inventory.MultiTenancy.Payments;

namespace Inventory.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}