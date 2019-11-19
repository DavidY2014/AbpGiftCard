using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpGiftCard.Configuration.Dto;

namespace AbpGiftCard.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpGiftCardAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
