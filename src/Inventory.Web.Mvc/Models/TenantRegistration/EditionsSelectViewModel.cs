using Abp.AutoMapper;
using Inventory.MultiTenancy.Dto;

namespace Inventory.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
