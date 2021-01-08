using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace SakariaBookstore.Controllers
{
    public class PrivacyController : Controller
    {
        private readonly IStringLocalizer<PrivacyController> _localizer;
        public PrivacyController(IStringLocalizer<PrivacyController> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {

            var message = _localizer["Message"];
            ViewData["Message"] = message;
            return View();
        }
    }
}
