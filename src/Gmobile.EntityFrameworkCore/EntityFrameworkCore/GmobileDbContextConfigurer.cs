using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Gmobile.EntityFrameworkCore
{
    public static class GmobileDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GmobileDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GmobileDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}