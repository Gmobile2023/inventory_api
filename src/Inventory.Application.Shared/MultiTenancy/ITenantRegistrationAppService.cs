using System.Threading.Tasks;
using Abp.Application.Services;
using Inventory.Editions.Dto;
using Inventory.MultiTenancy.Dto;

namespace Inventory.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}