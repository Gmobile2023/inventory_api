using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Inventory.Configure;
using Inventory.Startup;
using Inventory.Test.Base;

namespace Inventory.GraphQL.Tests
{
    [DependsOn(
        typeof(InventoryGraphQLModule),
        typeof(InventoryTestBaseModule))]
    public class InventoryGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InventoryGraphQLTestModule).GetAssembly());
        }
    }
}