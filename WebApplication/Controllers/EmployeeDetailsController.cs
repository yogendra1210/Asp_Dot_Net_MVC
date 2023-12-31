using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class EmployeeDetailsController : Controller
    {
        // GET: EmployeeDetails
        public ActionResult Index()
        {
            EmployeeDetailsEntities1 db = new EmployeeDetailsEntities1();
            var abc = db.Employees;
            return View(abc.ToList());
        }
        public ActionResult GetAllEmployee()
        {
            EmployeeDetailsEntities1 db = new EmployeeDetailsEntities1();
            List<Employee> emp = db.Employees.ToList();
            EmployeeViewModel empViewModel = new EmployeeViewModel();
            List<EmployeeViewModel> lstempViewModel = db.Employees.Select(
                x => new EmployeeViewModel {
                    EmpId = x.EmpId,
                    EmpName = x.EmpName,
                    Address=x.Address,
                    DeptId = x.DeptId,
                    DepartmentName =x.Department.DeptName
                }).ToList();
            return View(lstempViewModel);
        }

        public ActionResult GetEmployeeInfo(int EmpId)
        {
            EmployeeDetailsEntities1 db = new EmployeeDetailsEntities1();
            Employee e = db.Employees.SingleOrDefault(x=>x.EmpId==EmpId);
            EmployeeViewModel empViewModel = new EmployeeViewModel();
            empViewModel.EmpId = e.EmpId;
            empViewModel.EmpName = e.EmpName;
            empViewModel.Address = e.Address;
            empViewModel.DeptId = e.DeptId;
            empViewModel.DepartmentName = e.Department.DeptName;
            return View(empViewModel);
        }
    }
}