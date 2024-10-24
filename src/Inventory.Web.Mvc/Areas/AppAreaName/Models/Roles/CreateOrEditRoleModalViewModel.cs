using Abp.AutoMapper;
using Inventory.Authorization.Roles.Dto;
using Inventory.Web.Areas.AppAreaName.Models.Common;

namespace Inventory.Web.Areas.AppAreaName.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}