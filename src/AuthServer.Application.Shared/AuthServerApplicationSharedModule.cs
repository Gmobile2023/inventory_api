using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AuthServer
{
    [DependsOn(typeof(AuthServerCoreSharedModule))]
    public class AuthServerApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AuthServerApplicationSharedModule).GetAssembly());
        }
    }
}