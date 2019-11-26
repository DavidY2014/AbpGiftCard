using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpGiftCard.Authorization.Roles;
using AbpGiftCard.Authorization.Users;
using AbpGiftCard.MultiTenancy;
using AbpGiftCard.Entitys;

namespace AbpGiftCard.EntityFrameworkCore
{
    public class AbpGiftCardDbContext : AbpZeroDbContext<Tenant, Role, User, AbpGiftCardDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AbpGiftCardDbContext(DbContextOptions<AbpGiftCardDbContext> options)
            : base(options)
        {
        }

        public DbSet<Module> Modules { get; set; }


        public DbSet<ProductInformation> ProductInformations { get; set; }

        public DbSet<Catelog> Catelogs { get; set; }
        
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Finance> Finances { get; set; }

        public DbSet<OrderProductDetail> OrderProductDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CouponOrder> CouponOrders { get; set; }
        public DbSet<CouponFinanceDetail> CouponFinanceDetails { get; set; }
        public DbSet<Contract> Contracts { get; set; }


    }
}
