using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AuthServer.Authorization.Permissions.Dto;

namespace AuthServer.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
