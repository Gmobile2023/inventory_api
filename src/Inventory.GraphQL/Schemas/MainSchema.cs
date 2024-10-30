using System;
using Abp.Dependency;
using GraphQL.Types;
using Inventory.Queries.Container;
using Microsoft.Extensions.DependencyInjection;

namespace Inventory.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}