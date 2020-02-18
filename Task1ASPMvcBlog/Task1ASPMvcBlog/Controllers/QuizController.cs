using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task1ASPMvcBlog.Controllers
{
    public class QuizController : Controller
    {
        [HttpGet]
        public ActionResult Quiz()
        {
            ViewBag.Message = "Your quiz page";

            return View();
        }

        [HttpPost]
        public ActionResult Quiz(FormCollection form)
        {
            ViewBag.TextReturn = "Вы ввели" + form["dishName"];

            return View();
        }
    }
}