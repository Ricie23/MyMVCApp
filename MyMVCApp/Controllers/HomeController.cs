using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ContentResult Search(string name)
        {
            var input = HttpUtility.HtmlEncode(name);
            return Content(input);
        }
        public ActionResult About()
        { 
            return View();
        }

        public ActionResult Contact()
        {       
            return View();
        }
    }
}