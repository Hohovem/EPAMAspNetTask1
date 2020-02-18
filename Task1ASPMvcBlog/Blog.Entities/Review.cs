using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Entities
{
    public class Review
    {
        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }

        public UserData User { get; set; }
    }
}