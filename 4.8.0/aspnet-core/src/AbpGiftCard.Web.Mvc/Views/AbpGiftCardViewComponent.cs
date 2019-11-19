using Abp.AspNetCore.Mvc.ViewComponents;

namespace AbpGiftCard.Web.Views
{
    public abstract class AbpGiftCardViewComponent : AbpViewComponent
    {
        protected AbpGiftCardViewComponent()
        {
            LocalizationSourceName = AbpGiftCardConsts.LocalizationSourceName;
        }
    }
}
