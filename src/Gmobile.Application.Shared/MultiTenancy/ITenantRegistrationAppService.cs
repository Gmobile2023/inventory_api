using System.Threading.Tasks;
using Abp.Application.Services;
using Gmobile.Editions.Dto;
using Gmobile.MultiTenancy.Dto;

namespace Gmobile.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
        
        Task BuyNowSucceed(long paymentId);

        Task NewRegistrationSucceed(long paymentId);

        Task UpgradeSucceed(long paymentId);

        Task ExtendSucceed(long paymentId);
    }
}