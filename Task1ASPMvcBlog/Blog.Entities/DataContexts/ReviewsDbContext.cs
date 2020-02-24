using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Blog.Entities;

namespace Blog.Entities.DataContexts
{
    public class ReviewsDbContext : DbContext
    {
        public ReviewsDbContext() : base("ReviewsDbContext")
        {
            Database.SetInitializer<ReviewsDbContext>(new CreateDatabaseIfNotExists<ReviewsDbContext>());
        }
        public DbSet<Review> Reviews { get; set; }
    }
}