using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Gmobile.Authorization.Users;
using Gmobile.MultiTenancy;

namespace Gmobile.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}