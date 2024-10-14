using System;
using System.Collections.Generic;
using Gmobile.Organizations.Dto;

namespace Gmobile.Authorization.Users.Dto
{
    public class GetUserForEditOutput
    {
        public Guid? ProfilePictureId { get; set; }

        public UserEditDto User { get; set; }

        public UserRoleDto[] Roles { get; set; }

        public List<OrganizationUnitDto> AllOrganizationUnits { get; set; }

        public List<string> MemberedOrganizationUnits { get; set; }
        
        public string AllowedUserNameCharacters { get; set; }
        
        public bool IsSMTPSettingsProvided { get; set; }
    }
}