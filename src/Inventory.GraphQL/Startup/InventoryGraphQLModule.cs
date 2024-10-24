using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Inventory.Startup
{
    [DependsOn(typeof(InventoryCoreModule))]
    public class InventoryGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InventoryGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}