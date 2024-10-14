using Abp.AutoMapper;
using Gmobile.Organizations.Dto;

namespace Gmobile.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}
