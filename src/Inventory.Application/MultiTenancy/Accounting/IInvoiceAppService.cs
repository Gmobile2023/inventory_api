using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Inventory.MultiTenancy.Accounting.Dto;

namespace Inventory.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
