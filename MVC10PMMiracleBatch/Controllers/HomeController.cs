using MVC10PMMiracleBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC10PMMiracleBatch.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Hello World";
        }

        public int Index2()
        {
            return 1211;
        }

        public ActionResult GetHtmlPage()
        {
            return View("GetHtmlPage1");
        }

        public ActionResult GetHtmlPage2()
        {
            return View("~/Views/Default/AboutUs.cshtml");
        }

        public string GetHtmlPage3(int? id)
        {
            return "My Employee ID is " + id;
        }

        public string GetHtmlPage4(int? id)
        {
            return "My Employee ID is " + id
                      + " and Name is " + Request.QueryString["Name"];
        }

        public ActionResult GetViewExample()
        {
            int a = 10;
            ViewBag.Fname = "James";
            return View();
        }

        public ActionResult GetViewExample2()
        {
            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "James";
            emp.EmpSalary = 4567;

            ViewBag.EmpDetail = emp;
            return View();
        }

        public ActionResult GetViewExample3()
        {
            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "James";
            emp.EmpSalary = 4567;


            EmployeeModel emp1 = new Models.EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Anuj";
            emp1.EmpSalary = 6567;

            EmployeeModel emp2 = new Models.EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Radha";
            emp2.EmpSalary = 7567;

            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);

            ViewBag.listEmp = listEmp;

            return View();
        }

        public ActionResult GetViewExample4()
        {
            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "James";
            emp.EmpSalary = 4567;


            return View(emp);
        }

        public ActionResult GetViewExample5()
        {
            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "James";
            emp.EmpSalary = 4567;


            EmployeeModel emp1 = new Models.EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Anuj";
            emp1.EmpSalary = 6567;

            EmployeeModel emp2 = new Models.EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Radha";
            emp2.EmpSalary = 7567;

            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);


            return View(listEmp);
        }

        public ViewResult GetViewExample6(List<EmployeeModel> emptake)
        {
            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "James";
            emp.EmpSalary = 4567;


            EmployeeModel emp1 = new Models.EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Anuj";
            emp1.EmpSalary = 6567;

            EmployeeModel emp2 = new Models.EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Radha";
            emp2.EmpSalary = 7567;

            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);



            List<DepartmentModel> listdept = new List<Models.DepartmentModel>();

            DepartmentModel dept1 = new Models.DepartmentModel();
            dept1.DeptId = 1;
            dept1.DeptName = "Payroll";

            DepartmentModel dept2 = new Models.DepartmentModel();
            dept2.DeptId = 2;
            dept2.DeptName = "HR";


            listdept.Add(dept1);
            listdept.Add(dept2);

            EmpDept empdeptObj = new EmpDept();
            empdeptObj.lstEmp = listEmp;
            empdeptObj.lstDept = listdept;


            return View(empdeptObj);
        }

        public RedirectResult GotoURl()
        {
            return Redirect("http://www.google.com");
        }
        public RedirectResult GotoURl2()
        {
            return Redirect("~/Home/GetViewExample6?id=1");
        }

        public RedirectToRouteResult GotoUrl3()
        {

            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "James";
            emp.EmpSalary = 4567;


            EmployeeModel emp1 = new Models.EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Anuj";
            emp1.EmpSalary = 6567;

            EmployeeModel emp2 = new Models.EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Radha";
            emp2.EmpSalary = 7567;

            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);


            return RedirectToAction("GetViewExample6", "Home", listEmp);
        }

        public RedirectToRouteResult GotoUrl4()
        {
            return RedirectToRoute("biscuit");
        }

        public FileResult getFile()
        {
            return File("~/Web.config", "text/plain");
        }

        public FileResult getFile2()
        {
            return File("~/ActionResult.pdf", "application/pdf","DownloadFile.pdf");
        }

        public ViewResult ExampleonPartialView()
        {

            return View();
        }

        public ViewResult ExampleonPartialView2()
        {
            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "alok";
            emp.EmpSalary = 4567;


            EmployeeModel emp1 = new Models.EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Anuj";
            emp1.EmpSalary = 6567;

            EmployeeModel emp2 = new Models.EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Radha";
            emp2.EmpSalary = 7567;

            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);

            return View(listEmp);
        }

        public PartialViewResult ExampleonPartialView3()
        {
            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "alok";
            emp.EmpSalary = 4567;


            EmployeeModel emp1 = new Models.EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Anuj";
            emp1.EmpSalary = 6567;

            EmployeeModel emp2 = new Models.EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Radha";
            emp2.EmpSalary = 7567;

            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);

            return PartialView("_MyEmployeePartialView", listEmp);
        }

        public JsonResult GetJsonData()
        {
            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "alok";
            emp.EmpSalary = 4567;


            EmployeeModel emp1 = new Models.EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Anuj";
            emp1.EmpSalary = 6567;

            EmployeeModel emp2 = new Models.EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Radha";
            emp2.EmpSalary = 7567;

            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);

            return Json(listEmp,JsonRequestBehavior.AllowGet);


        }


        public ViewResult AccessjsonData()
        {

            return View();
        }
    }
}