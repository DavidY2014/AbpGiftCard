using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpGiftCard.Authorization.Roles;
using AbpGiftCard.Authorization.Users;
using AbpGiftCard.MultiTenancy;

namespace AbpGiftCard.EntityFrameworkCore
{
    public class AbpGiftCardDbContext : AbpZeroDbContext<Tenant, Role, User, AbpGiftCardDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AbpGiftCardDbContext(DbContextOptions<AbpGiftCardDbContext> options)
            : base(options)
        {
        }
    }
}
