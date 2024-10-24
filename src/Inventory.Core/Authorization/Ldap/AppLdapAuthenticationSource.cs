using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Inventory.Authorization.Users;
using Inventory.MultiTenancy;

namespace Inventory.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}