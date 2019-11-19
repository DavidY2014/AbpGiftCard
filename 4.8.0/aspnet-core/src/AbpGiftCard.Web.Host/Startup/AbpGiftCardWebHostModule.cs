using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpGiftCard.Configuration;

namespace AbpGiftCard.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpGiftCardWebCoreModule))]
    public class AbpGiftCardWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpGiftCardWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpGiftCardWebHostModule).GetAssembly());
        }
    }
}
