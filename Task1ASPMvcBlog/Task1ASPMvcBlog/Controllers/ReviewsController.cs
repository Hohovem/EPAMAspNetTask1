using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Entities;
using Task1ASPMvcBlog.DataContexts;

namespace Task1ASPMvcBlog.Controllers
{
    public class ReviewsController : Controller
    {
        CommentsDb db = new CommentsDb();

        [HttpPost]
        public ActionResult Reviews(string commentName, string content)
        {
            //Comments.Comments.Add(new Comment(
            //    imageArdress: "~/Content/Images/Review/defaultCommentImage.jpg",
            //    senderName: commentName,
            //    content: content,
            //    postDate: "11.2.15"));

            return View(db.Comments);
        }

        [HttpGet]
        public ActionResult Reviews()
        {
            ViewBag.Message = "Your application reviews page.";



            return View(db.Comments);
        }
    }
}