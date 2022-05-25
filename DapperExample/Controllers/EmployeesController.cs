using DapperExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DapperExample.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.GetEmployees());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int i = db.SaveEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            return View();
        }

        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.GetEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            int i = db.UpdateEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            return View();
        }
        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.GetEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            int i = db.DeleteEmployee(id);
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            return View();
        }

        public ActionResult ViewBagandViewData()
        {
            ViewData["Id"] = "Anil";
            return RedirectToAction("ViewBagandViewData2");
        }

        public ActionResult ViewBagandViewData2()
        {
            string data=ViewData["Id"].ToString();
            return View();
        }

        public ActionResult TempdataExample()
        {
            TempData["StudenetName"] = "Anil";
            return RedirectToAction("TempdataExample2");
        }

        public ActionResult TempdataExample2()
        {


            string Name = Convert.ToString(TempData["StudenetName"]);

            // TempData.Keep();
            var s = TempData.Peek("StudenetName");

            return Content(s.ToString());
        }
    }
}