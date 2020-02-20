using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1ASPMvcBlog.DataContexts

namespace Blog.Entities.UnitOfWork
{
    public class UoW : IUoW, IDisposable
    {
        private ReviewDbContext

        public UoW()
        {

        }

        public IRepository<Review> Reviews => new EFRepository<Review>();

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void CreateDbContext()
        {

        }
    }
}
