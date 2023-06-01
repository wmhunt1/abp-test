using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace abp-test.EntityFrameworkCore
{
    public static class abp-testDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<abp-testDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<abp-testDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
