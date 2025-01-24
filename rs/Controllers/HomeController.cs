using Microsoft.AspNetCore.Mvc;
using rs.Models;
using System.Diagnostics;

namespace rs.Controllers
{
    public class HomeController : Controller
    {
      private readonly rsDbContext db;

        public HomeController(rsDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("s") != null)
            {
                ViewBag.s = HttpContext.Session.GetString("s");
            }
            else
            {
                return RedirectToAction("login");
            }
            return View();
        }
        public IActionResult register()
        {

            return View();
        }
        [HttpPost]
        public IActionResult register(RegUser reg)
        {
            db.UserReg.Add(reg);
            db.SaveChanges();
            return RedirectToAction("login");
        }

        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("s") != null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult login(RegUser log)
        {
            var login = db.UserReg.Where(db => db.Email == log.Email && db.Password == log.Password).FirstOrDefault();
            if (login != null)
            {
                HttpContext.Session.SetString("s", login.Email);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.m = "Login Failed";
            }
            return View();
        }

        public IActionResult logout()
        {

            if (HttpContext.Session.GetString("s") != null)
            {
                HttpContext.Session.Remove("s");
                return RedirectToAction("login");
            }
            return View();
        }

    }
}
