using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Inventory.Authorization.Permissions.Dto;

namespace Inventory.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
