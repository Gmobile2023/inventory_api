﻿using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace Inventory.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class InventoryRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<InventoryDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected InventoryRepositoryBase(IDbContextProvider<InventoryDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="InventoryRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class InventoryRepositoryBase<TEntity> : InventoryRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected InventoryRepositoryBase(IDbContextProvider<InventoryDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)!!!
    }
}
