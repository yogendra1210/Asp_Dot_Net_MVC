using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class EmployeeViewModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public Nullable<int> DeptId { get; set; }
        public string Address { get; set; }
        public string  DepartmentName { get; set; }

        public bool remember { get; set; }

    }
}