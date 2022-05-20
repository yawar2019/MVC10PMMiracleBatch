using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace DapperExample.Models
{
    public class EmployeeContext
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");
        //public List<EmployeeModel> GetEmployees()
        //{
        //    var listemp = con.Query<EmployeeModel>("SELECT* FROM [Employee].[dbo].[employeeDetails]").ToList();

        //    return listemp;
        //}


        public List<EmployeeModel> GetEmployees()
        {
            var listemp = con.Query<EmployeeModel>("sp_employee",commandType:CommandType.StoredProcedure).ToList();

            return listemp;
        }

        public int SaveEmployee(EmployeeModel emp)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@EmpName",emp.EmpName);
            parameter.Add("@EmpSalary",emp.EmpSalary);

            int i = con.Execute("sp_InsertEmployee",param: parameter, commandType: CommandType.StoredProcedure);
            return i;
        }
    }
}