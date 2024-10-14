using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Gmobile
{
    [DependsOn(typeof(GmobileCoreSharedModule))]
    public class GmobileApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GmobileApplicationSharedModule).GetAssembly());
        }
    }
}