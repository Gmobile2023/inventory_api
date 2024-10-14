using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Gmobile
{
    public class GmobileClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GmobileClientModule).GetAssembly());
        }
    }
}
