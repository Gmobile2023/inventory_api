using Abp.Domain.Services;

namespace Gmobile
{
    public abstract class GmobileDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected GmobileDomainServiceBase()
        {
            LocalizationSourceName = GmobileConsts.LocalizationSourceName;
        }
    }
}
