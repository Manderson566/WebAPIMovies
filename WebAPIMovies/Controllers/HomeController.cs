using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPIMovies.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Review()
        {
            ViewBag.Title = "Review Page";

            return View();
        }

        public ActionResult UserInfo()
        {
            ViewBag.Title = "User Info Page";

            return View();
        }
    }
}
