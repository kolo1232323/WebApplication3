using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class BigViewModel
    {
        public IEnumerable<ApplicationUser> Users { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}