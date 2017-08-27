using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class ActionVerbsController : Controller
    {
        // GET: ActionVerbs
        [HttpGet]
        public ActionResult Index()
        {
            return View("ActionVerbsIndex");
        }
    }
}