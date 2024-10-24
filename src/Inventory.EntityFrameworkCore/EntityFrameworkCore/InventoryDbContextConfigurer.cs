using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Inventory.EntityFrameworkCore
{
    public static class InventoryDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<InventoryDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<InventoryDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}