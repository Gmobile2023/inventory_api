using Abp.AutoMapper;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Gmobile.ApiClient;
using Gmobile.Mobile.MAUI.Core.ApiClient;

namespace Gmobile
{
    [DependsOn(typeof(GmobileClientModule), typeof(AbpAutoMapperModule))]

    public class GmobileMobileMAUIModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            Configuration.ReplaceService<IApplicationContext, MAUIApplicationContext>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GmobileMobileMAUIModule).GetAssembly());
        }
    }
}