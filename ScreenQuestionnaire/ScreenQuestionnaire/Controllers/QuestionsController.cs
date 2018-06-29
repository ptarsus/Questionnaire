using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScreenQuestionnaire.Controllers
{
    public class QuestionsController : Controller
    {
        // GET: Questions
        [Route("Questions")]
        public ActionResult Index()
        {
            return View();
        }
    }
}