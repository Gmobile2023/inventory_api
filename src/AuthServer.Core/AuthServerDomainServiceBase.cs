using Abp.Domain.Services;

namespace AuthServer
{
    public abstract class AuthServerDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected AuthServerDomainServiceBase()
        {
            LocalizationSourceName = AuthServerConsts.LocalizationSourceName;
        }
    }
}
