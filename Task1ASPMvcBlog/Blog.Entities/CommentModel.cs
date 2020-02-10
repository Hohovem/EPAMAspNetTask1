using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Entities
{
    public class CommentModel
    {
        public CommentModel()
        {
            ImageArdress = "~/Content/Images/Review/defaultCommentImage.jpg";
            SenderName = "DefaultName";
            Content = "Bla bla blah";
            PostDate = "05/29/2015";
        }

        public CommentModel(string imageArdress, string senderName, string content, string postDate)
        {
            ImageArdress = imageArdress;
            SenderName = senderName;
            Content = content;
            PostDate = postDate;
        }

        public string ImageArdress { get; }
        public string SenderName { get; }
        public string Content { get; }
        public string PostDate { get; }
    }
}