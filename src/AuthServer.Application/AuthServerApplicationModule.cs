using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AuthServer.Authorization;

namespace AuthServer
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(AuthServerApplicationSharedModule),
        typeof(AuthServerCoreModule)
        )]
    public class AuthServerApplicationModule : AbpModule
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
            IocManager.RegisterAssemblyByConvention(typeof(AuthServerApplicationModule).GetAssembly());
        }
    }
}