using System.Collections.Generic;
using Inventory.Authorization.Delegation;
using Inventory.Authorization.Users.Delegation.Dto;

namespace Inventory.Web.Areas.AppAreaName.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }

        public List<UserDelegationDto> UserDelegations { get; set; }

        public string CssClass { get; set; }
    }
}
