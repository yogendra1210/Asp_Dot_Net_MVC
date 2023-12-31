using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string HelloWorld()
        {
            return "Hello World";
        }

        public string HelloWorld1(string Name)
        {
            return "Hello "+Name;
        }
    }
}