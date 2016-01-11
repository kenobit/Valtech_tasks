using TestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApp.Controllers
{
    public class PeopleController : Controller
    {
        UserContext context = new UserContext();
        public ActionResult PersAdd()
        {
            return View();
        }

        public ActionResult Users()
        {
            AddRange();
            UsersViewModel model = new UsersViewModel();
            return View(context.People.ToList());
        }
        void AddRange()
        {
            context.People.Add(new Person { ID = 0, Name = "qweqweqwe" });
            context.People.Add(new Person { ID = 1, Name = "werwerwer" });
            context.People.Add(new Person { ID = 2, Name = "ertertert" });
            context.People.Add(new Person { ID = 3, Name = "rtyrtyrty" });
            context.SaveChanges();
        }
    }
}