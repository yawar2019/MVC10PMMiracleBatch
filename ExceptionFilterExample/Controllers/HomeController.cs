using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionFilterExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //[HandleError(View="Error1")]
        public ActionResult getCustomError()
        {
            try
            {
                int a = 10; string b = "test"; int c = 0;
                c = a / Convert.ToInt32(b);
            }
            catch(Exception ex)
            {
                if (ex.Message == "Attempted to divide by zero.")
                    return View("Error1", new HandleErrorInfo(ex, "Home", "getCustomError"));
                else {
                    throw ex;
                }
            }

            return View();
        }
        [OutputCache(Duration =20,Location =System.Web.UI.OutputCacheLocation.Client)]
        public ActionResult GetCacheData()
        {

            return View();
        }
        [HttpPost]
        public ActionResult GetCacheData(string name)
        {

            return View();
        }
    }
}