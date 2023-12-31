﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class Employee1Controller : Controller
    {
        // GET: Employee1
        public ActionResult Index()
        {
            List<Employee> lst = new List<Employee>();
            lst.Add(new Employee { EmpId = 1, EmpName = "Yogi", Address = "IT" });
            lst.Add(new Employee { EmpId = 2, EmpName = "Abhi", Address = "COMP" });
            lst.Add(new Employee { EmpId = 3, EmpName = "Ravi", Address = "IT" });
            lst.Add(new Employee { EmpId = 4, EmpName = "Suresh", Address = "ETC" });
            ViewBag.MyListEmp = lst;
            ViewData["ListEmp"] = lst;
            return View();
        }
    }
}