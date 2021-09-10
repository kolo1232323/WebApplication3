using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication3.Controllers
{
    public class UserController : Controller
    {
        protected UserManager<ApplicationUser> UserManager { get; set; }
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: UserController
        public ActionResult Index()
        {       
            return View(db.Users.ToList());
        }

        public ActionResult GetInstructor(string id)
        {
/*          this.UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = db.Users.ToList();
            List<Course> courses = db.Courses.ToList();
            BigViewModel bigViewModel = new BigViewModel() { User = user, Courses = courses};*/
            return PartialView("_InstructorSelectPartial");
        }

        public ActionResult SelectInstructor()
        {
            return this.PartialView("_InstructorSelectPartial", db.Users.ToList());
        }
    }
}