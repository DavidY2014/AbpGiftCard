using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpGiftCard.Authorization;

namespace AbpGiftCard
{
    [DependsOn(
        typeof(AbpGiftCardCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpGiftCardApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpGiftCardAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AbpGiftCardApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
