using Abp.AutoMapper;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Inventory.ApiClient;
using Inventory.Mobile.MAUI.Core.ApiClient;

namespace Inventory
{
    [DependsOn(typeof(InventoryClientModule), typeof(AbpAutoMapperModule))]

    public class InventoryMobileMAUIModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            Configuration.ReplaceService<IApplicationContext, MAUIApplicationContext>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InventoryMobileMAUIModule).GetAssembly());
        }
    }
}