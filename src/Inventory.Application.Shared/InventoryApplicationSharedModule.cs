using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Inventory
{
    [DependsOn(typeof(InventoryCoreSharedModule))]
    public class InventoryApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InventoryApplicationSharedModule).GetAssembly());
        }
    }
}