using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AuthServer.Startup
{
    [DependsOn(typeof(AuthServerCoreModule))]
    public class AuthServerGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AuthServerGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}