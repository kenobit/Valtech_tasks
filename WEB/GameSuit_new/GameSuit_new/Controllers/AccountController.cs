using GameSuit_new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace GameSuit_new.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LogViewModel model,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (ValidateUser(model.UserName,model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Wrong login - password combination");
                }
            }
            return null;
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }

        private bool ValidateUser(string login, string password)
        {
            bool isValid = false;

            using (UserContext context = new UserContext())
            {
                try
                {
                    User user = (from u in context.Users
                                 where u.Login == login && u.Password == password
                                 select u).FirstOrDefault();
                    if (user!=null)
                    {
                        isValid = true;
                    }
                }
                catch (Exception)
                {
                    isValid = false;
                }
            }
            return isValid;
        }
    }
}