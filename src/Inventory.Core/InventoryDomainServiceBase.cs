using Abp.Domain.Services;

namespace Inventory
{
    public abstract class InventoryDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected InventoryDomainServiceBase()
        {
            LocalizationSourceName = InventoryConsts.LocalizationSourceName;
        }
    }
}
