using Abp.Authorization;
using AuthServer.Authorization.Roles;
using AuthServer.Authorization.Users;

namespace AuthServer.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
