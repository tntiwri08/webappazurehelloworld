using HelloWorld.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class ActionFilterDemoController : Controller
    {
       
        [CustomActionFilter]
        [CustExceptionFilter]
        public string Index()
        {
            return DateTime.Now.ToString("T");
        }

        [OutputCache(Duration = 10)]
        public ActionResult OutPutTest()
        {
            ViewBag.Date = DateTime.Now.ToString("T");
            return View("Index");
        }
    }
}