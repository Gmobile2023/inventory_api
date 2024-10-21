using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using AuthServer.Authorization.Users;
using AuthServer.MultiTenancy;

namespace AuthServer.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}