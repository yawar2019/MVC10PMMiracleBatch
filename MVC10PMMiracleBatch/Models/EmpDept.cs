using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC10PMMiracleBatch.Models
{
    public class EmpDept
    {
        public List<EmployeeModel> lstEmp { get; set; }
        public List<DepartmentModel> lstDept { get; set; }
    }
}