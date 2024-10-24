﻿using Inventory.EntityFrameworkCore;

namespace Inventory.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly InventoryDbContext _context;

        public InitialHostDbBuilder(InventoryDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}