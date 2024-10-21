using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using AuthServer.Configure;
using AuthServer.Startup;
using AuthServer.Test.Base;

namespace AuthServer.GraphQL.Tests
{
    [DependsOn(
        typeof(AuthServerGraphQLModule),
        typeof(AuthServerTestBaseModule))]
    public class AuthServerGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AuthServerGraphQLTestModule).GetAssembly());
        }
    }
}