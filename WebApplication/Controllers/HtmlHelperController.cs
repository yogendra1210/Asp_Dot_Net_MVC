using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HtmlHelperController : Controller
    {
        // GET: HtmlHelper
        public ActionResult Index()
        {
            EmployeeDetailsEntities1 db = new EmployeeDetailsEntities1();
            List<Department> dept = db.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(dept, "DeptId", "DeptName");
            return View();
        }
    }
}