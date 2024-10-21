using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AuthServer
{
    public class AuthServerClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AuthServerClientModule).GetAssembly());
        }
    }
}
