using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Gmobile
{
    public class GmobileCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GmobileCoreSharedModule).GetAssembly());
        }
    }
}