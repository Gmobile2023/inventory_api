using System.Threading.Tasks;
using Abp.Application.Services;
using Inventory.Sessions.Dto;

namespace Inventory.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
