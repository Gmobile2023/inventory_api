using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Inventory
{
    public class InventoryCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InventoryCoreSharedModule).GetAssembly());
        }
    }
}