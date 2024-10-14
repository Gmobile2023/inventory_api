using Abp.Dependency;
using GraphQL.Types;
using Gmobile.Queries.Container;
using System;
using GraphQL.Conversion;
using Microsoft.Extensions.DependencyInjection;

namespace Gmobile.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
            NameConverter = new CamelCaseNameConverter();
        }
    }
}