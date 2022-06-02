using MVC10PMMiracleBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC10PMMiracleBatch.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserDetail userdet)
        {
            LoginEntities db = new Models.LoginEntities();
            var user = db.UserDetails.Where(s => s.UserName == userdet.UserName && s.Password == userdet.Password);
            if(user!=null)
            {
                FormsAuthentication.SetAuthCookie(userdet.UserName, false);
                return Redirect("~/Login/Dashboard");
            }
            return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/Login/Login");
        }

        [Authorize]
        public ActionResult Dashboard()
        {
            return View();
        }

        [Authorize(Roles="Admin")]
        public ActionResult ContactUs()
        {
            return View();
        }
        [Authorize(Roles = "Employee")]

        public ActionResult AboutUS()
        {
            return View();
        }
    }
}