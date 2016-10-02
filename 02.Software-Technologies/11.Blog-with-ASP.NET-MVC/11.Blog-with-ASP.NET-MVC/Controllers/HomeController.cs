using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using _11.Blog_with_ASP.NET_MVC.Models;

namespace _11.Blog_with_ASP.NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            
            var posts = db.Posts.Include(p => p.Author).OrderByDescending(p => p.Date).Take(3);
            return View(posts.ToList());
        }
    }
}