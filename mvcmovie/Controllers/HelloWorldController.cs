using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcmovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            //return "This is my <b>defualt</b> aciton";
            return View();
        }

        // GET: /HelloWorld/Welcome
        public ActionResult Welcome(int Id, int numTimes = 1)
        {
            ViewBag.Id = "hello" + Id;
            ViewBag.NumTimes = numTimes;

            //return HttpUtility.HtmlEncode("Hello " + Id + ",Numtimes is: " + numTimes);
            return View();
        }
    }
}