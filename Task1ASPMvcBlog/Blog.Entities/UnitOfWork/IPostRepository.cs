using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.UnitOfWork
{
    interface IPostRepository<T> : IRepository<T> where T : class
    {
        int GetCommentLenght();
    }
}
