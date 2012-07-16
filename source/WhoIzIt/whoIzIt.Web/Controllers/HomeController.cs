using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace whoIzIt.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string authUrl = String.Format("https://www.facebook.com/dialog/oauth?client_id={0}&redirect_uri={1}");
            ViewBag.Port = Request.Url.Port;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }

        [OutputCache(Duration=60*60*24*365, Location=OutputCacheLocation.ServerAndClient)]
        public ActionResult Channel()
        {
            return View();
        }
    }
}
