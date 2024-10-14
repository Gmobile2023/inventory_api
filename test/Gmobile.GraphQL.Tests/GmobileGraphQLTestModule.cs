using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Gmobile.Configure;
using Gmobile.Startup;
using Gmobile.Test.Base;

namespace Gmobile.GraphQL.Tests
{
    [DependsOn(
        typeof(GmobileGraphQLModule),
        typeof(GmobileTestBaseModule))]
    public class GmobileGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GmobileGraphQLTestModule).GetAssembly());
        }
    }
}