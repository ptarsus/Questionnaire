using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScreenQuestionnaire.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home/Index")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("Home/Questions")]
        public ActionResult Questions()
        {
            return View();
        }
    }
}