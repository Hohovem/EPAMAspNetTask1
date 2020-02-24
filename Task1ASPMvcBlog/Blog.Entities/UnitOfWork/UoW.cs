using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.DataContexts;

namespace Blog.Entities.UnitOfWork
{
    public class UoW : IUoW, IDisposable
    {
        private ReviewsDbContext DbContext { get; set; }

        public UoW()
        {
            CreateDbContext();
        }

        public IRepository<Review> Reviews => new EFRepository<Review>(DbContext);

        public void Commit()
        {
            DbContext.SaveChanges();
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }

        public void CreateDbContext()
        {
            DbContext = new ReviewsDbContext();
        }
    }
}
