using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.Name = "Ashish";
            List<string> str = new List<string>();
            str.Add("Yogi");
            str.Add("Mandhare");
            str.Add("Hii");
            //ViewBag.NameList = str;
            return View();
        }
    }
}