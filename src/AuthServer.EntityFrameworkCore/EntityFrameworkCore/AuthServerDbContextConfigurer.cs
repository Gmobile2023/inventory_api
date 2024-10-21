using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AuthServer.EntityFrameworkCore
{
    public static class AuthServerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AuthServerDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AuthServerDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}