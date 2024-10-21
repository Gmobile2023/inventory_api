using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using AuthServer.MultiTenancy.Accounting.Dto;

namespace AuthServer.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
