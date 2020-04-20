using BlogMvcApp.NewFolder1;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        private UserManager<ApplicationUser> userManager;
        // GET: Account

        public AdminController()
        {
            userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new IdentityDataContext()));

        }
        public ActionResult Index()
        {
            return View(userManager.Users);
        }
    }
}