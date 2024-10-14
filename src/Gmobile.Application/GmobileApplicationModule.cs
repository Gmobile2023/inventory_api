using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Gmobile.Authorization;

namespace Gmobile
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(GmobileApplicationSharedModule),
        typeof(GmobileCoreModule)
        )]
    public class GmobileApplicationModule : AbpModule
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
            IocManager.RegisterAssemblyByConvention(typeof(GmobileApplicationModule).GetAssembly());
        }
    }
}