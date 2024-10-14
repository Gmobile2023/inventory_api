using Abp.Authorization;
using Gmobile.Authorization.Roles;
using Gmobile.Authorization.Users;

namespace Gmobile.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
