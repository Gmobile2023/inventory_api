using Abp.Modules;
using AuthServer.Test.Base;

namespace AuthServer.Tests
{
    [DependsOn(typeof(AuthServerTestBaseModule))]
    public class AuthServerTestModule : AbpModule
    {
       
    }
}
