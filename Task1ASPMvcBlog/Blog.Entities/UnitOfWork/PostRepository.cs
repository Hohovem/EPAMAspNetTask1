using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.UnitOfWork
{
    public class PostRepository : EFRepository<Review>, IPostRepository<Review>
    {
        public PostRepository(DbContext context) : base(context) { }

        public int GetCommentLenght()
        {
            return int.Parse(DbSet.Select(p => p.Content.Length).ToString());
        }
    }
}
