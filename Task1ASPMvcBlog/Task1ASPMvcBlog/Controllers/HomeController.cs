using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1ASPMvcBlog.Models;

namespace Task1ASPMvcBlog.Controllers
{
    public class HomeController : Controller
    {
        ICollection<CommentModel> Comments = new List<CommentModel>
        {
            new CommentModel(),
            new CommentModel(),
            new CommentModel(),
            new CommentModel(),
            new CommentModel()
        };

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Reviews(string commentName, string content)
        {
            Comments.Add(new CommentModel(
                imageArdress: "~/Content/Images/Review/defaultCommentImage.jpg",
                senderName:commentName, 
                content:content, 
                postDate:"11.2.15"));

            return View(Comments);
        }

        [HttpGet]
        public ActionResult Reviews()
        {
            ViewBag.Message = "Your application reviews page.";

            

            return View(Comments);
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