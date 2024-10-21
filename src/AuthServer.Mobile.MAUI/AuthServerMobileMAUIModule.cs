using Abp.AutoMapper;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AuthServer.ApiClient;
using AuthServer.Mobile.MAUI.Core.ApiClient;

namespace AuthServer
{
    [DependsOn(typeof(AuthServerClientModule), typeof(AbpAutoMapperModule))]

    public class AuthServerMobileMAUIModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            Configuration.ReplaceService<IApplicationContext, MAUIApplicationContext>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AuthServerMobileMAUIModule).GetAssembly());
        }
    }
}