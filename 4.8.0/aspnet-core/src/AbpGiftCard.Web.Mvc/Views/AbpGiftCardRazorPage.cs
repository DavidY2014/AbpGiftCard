using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace AbpGiftCard.Web.Views
{
    public abstract class AbpGiftCardRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AbpGiftCardRazorPage()
        {
            LocalizationSourceName = AbpGiftCardConsts.LocalizationSourceName;
        }
    }
}
