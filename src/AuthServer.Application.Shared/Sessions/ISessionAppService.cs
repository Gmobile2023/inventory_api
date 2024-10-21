using System.Threading.Tasks;
using Abp.Application.Services;
using AuthServer.Sessions.Dto;

namespace AuthServer.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
