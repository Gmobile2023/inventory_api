using Abp.Authorization;
using Inventory.Authorization.Roles;
using Inventory.Authorization.Users;

namespace Inventory.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
