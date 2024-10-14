using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Gmobile.Authorization.Users.Dto;

namespace Gmobile.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<PagedResultDto<UserLoginAttemptDto>> GetUserLoginAttempts(GetLoginAttemptsInput input);
    }
}
