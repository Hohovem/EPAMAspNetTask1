using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task1ASPMvcBlog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Reviews()
        {
            ViewBag.Message = "Your application reviews page.";

            return View();
        }

        [HttpGet]
        public ActionResult Profile()
        {
            ViewBag.Message = "Your profile page";

            return View();
        }

        [HttpPost]
        public ActionResult Profile(FormCollection form)
        {
            ViewBag.TextReturn = "Вы ввели" + form["dishName"];

            return View();
        }
    }
}