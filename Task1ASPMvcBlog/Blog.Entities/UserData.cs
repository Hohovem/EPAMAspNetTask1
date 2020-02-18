﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities
{
    public class UserData
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Review> Comments { get; set; }
    }
}
