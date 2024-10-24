using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using Inventory.Queries.Container;
using System;

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