using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Inventory.Authorization;

namespace Inventory
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(InventoryApplicationSharedModule),
        typeof(InventoryCoreModule)
        )]
    public class InventoryApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InventoryApplicationModule).GetAssembly());
        }
    }
}