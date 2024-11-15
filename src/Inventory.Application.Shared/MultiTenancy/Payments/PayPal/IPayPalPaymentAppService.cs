﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Inventory.MultiTenancy.Payments.PayPal.Dto;

namespace Inventory.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
