﻿using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Gmobile.MultiTenancy.Accounting.Dto;

namespace Gmobile.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
