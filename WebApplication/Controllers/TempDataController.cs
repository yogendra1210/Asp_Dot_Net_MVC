using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData
        public ActionResult Index()
        {
            ViewBag.EmployeeNameVB = "Ashish";
            ViewData["EmployeeNameVD"] = "John";
            TempData["EmployeeNameTD"] = "Marry";
            TempData.Keep();
            return View();
        }

        public ActionResult Index1()
        {
            TempData.Keep();
            return View();
        }
    }
}