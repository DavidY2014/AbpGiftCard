using Microsoft.AspNetCore.Antiforgery;
using AbpGiftCard.Controllers;

namespace AbpGiftCard.Web.Host.Controllers
{
    public class AntiForgeryController : AbpGiftCardControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
