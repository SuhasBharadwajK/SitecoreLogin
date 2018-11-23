using SitecoreLogin.Feature.Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreLogin.Feature.Login.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Feature/Login/UserLogin/LoginForm/Index.cshtml", new LoginViewModel());
        }

        [HttpPost]
        public ActionResult LoginUser(LoginViewModel loginViewModel)
        {
            if (!this.IsUserValid(loginViewModel.Email, loginViewModel.Password))
            {
                loginViewModel.IsInvalidAttempt = true;
                return View("~/Views/Feature/Login/UserLogin/LoginForm/Index.cshtml", loginViewModel);
            }

            return Redirect("/dashboard");
        }

        public ActionResult ForgotPassword()
        {
            return View("~/Views/Feature/Login/UserLogin/ForgotPassword/Index.cshtml");
        }

        private bool IsUserValid(string email, string password)
        {
            return email == "suhas" && password == "suhas";
        }
    }
}