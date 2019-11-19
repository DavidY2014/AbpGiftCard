using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AbpGiftCard.EntityFrameworkCore
{
    public static class AbpGiftCardDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpGiftCardDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpGiftCardDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
