using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Gmobile.Startup
{
    [DependsOn(typeof(GmobileCoreModule))]
    public class GmobileGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GmobileGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}