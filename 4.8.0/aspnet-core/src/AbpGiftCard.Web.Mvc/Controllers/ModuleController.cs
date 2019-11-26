using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbpGiftCard.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AbpGiftCard.Web.Mvc.Controllers
{
    public class ModuleController : AbpGiftCardControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}