﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.UnitOfWork
{
    public interface IUoW
    {
        void Commit();

        IRepository<Review> Reviews { get; }
    }
}
