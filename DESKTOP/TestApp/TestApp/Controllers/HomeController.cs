using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApp.Models;
using System.Web.Mvc;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Sum()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sum(SumViewModel model)
        {
            int result = model.a + model.b;
            return RedirectToAction("Res", "Home", new { res = result });
        }

        public ActionResult Res(int res)
        {
            ResViewModel model = new ResViewModel() { res = res };
            return View(model);
        }
    }
}