using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Blog.Entities;

namespace Task1ASPMvcBlog.DataContexts
{
    public class CommentsDb : DbContext
    {
        public CommentsDb() : base("DefaultConnection")
        {

        }

        public DbSet<CommentModel> Comments { get; set; }
    }
}