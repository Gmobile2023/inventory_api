using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AuthServer
{
    public class AuthServerCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AuthServerCoreSharedModule).GetAssembly());
        }
    }
}