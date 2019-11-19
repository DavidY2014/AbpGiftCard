using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AbpGiftCard.Controllers;

namespace AbpGiftCard.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : AbpGiftCardControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
