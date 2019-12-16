using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int i = 1;

            string str = "hello";
            bool t = false;
            float f= 12.5f;
            return View();
        }

        public ActionResult Aa()
        {
            return null;
        }
    }
}