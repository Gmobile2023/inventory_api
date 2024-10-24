using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Inventory
{
    public class InventoryClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InventoryClientModule).GetAssembly());
        }
    }
}
