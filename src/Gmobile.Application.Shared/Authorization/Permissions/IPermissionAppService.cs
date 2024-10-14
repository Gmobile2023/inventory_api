using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Gmobile.Authorization.Permissions.Dto;

namespace Gmobile.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
