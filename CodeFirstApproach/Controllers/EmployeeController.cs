using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        //commands:Enable-Migrations,Add-Migration addedDeptId,update-database
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index2()
        {
            var result = (from e in db.EmployeeModels
                          join d in db.DepartmentModels
                          on e.DeptId equals d.DeptId
                          select new EmpDeptModel
                          {
                              EmpId=e.EmpId,
                              EmpName=e.EmpName,
                              EmpSalary=e.EmpSalary,
                              DepartName = d.DeptName,
                          }
                        ).ToList();
            return View(result);
        }
        //public ActionResult Index()
        //{
        //    return View(db.EmployeeModels.ToList());
        //}
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            db.EmployeeModels.Add(emp);//generate insert query
            int i=db.SaveChanges();//execute query will return numbers of rows affected
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Edit(int? id)
        {
           EmployeeModel emp= db.EmployeeModels.Find(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
           db.Entry(emp).State=EntityState.Modified;//generate Update query

            int i = db.SaveChanges();//execute query will return numbers of rows affected
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
            db.EmployeeModels.Remove(emp);
            int i = db.SaveChanges();//execute query will return numbers of rows affected
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}