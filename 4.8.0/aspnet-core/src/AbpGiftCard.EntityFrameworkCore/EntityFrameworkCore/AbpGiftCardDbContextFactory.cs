using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AbpGiftCard.Configuration;
using AbpGiftCard.Web;

namespace AbpGiftCard.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpGiftCardDbContextFactory : IDesignTimeDbContextFactory<AbpGiftCardDbContext>
    {
        public AbpGiftCardDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpGiftCardDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpGiftCardDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpGiftCardConsts.ConnectionStringName));

            return new AbpGiftCardDbContext(builder.Options);
        }
    }
}
