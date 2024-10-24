using Abp.Modules;
using Inventory.Test.Base;

namespace Inventory.Tests
{
    [DependsOn(typeof(InventoryTestBaseModule))]
    public class InventoryTestModule : AbpModule
    {
       
    }
}
