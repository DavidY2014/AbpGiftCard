using System.Threading.Tasks;
using AbpGiftCard.Configuration.Dto;

namespace AbpGiftCard.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
