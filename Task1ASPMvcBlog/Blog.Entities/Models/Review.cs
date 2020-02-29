using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Entities
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [StringLength(20, MinimumLength = 4)]
        public string AuthorNameTest { get; set; }

        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CreatedTime { get; set; }
    }
}