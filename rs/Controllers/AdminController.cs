using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using rs.Models;

namespace rs.Controllers
{
    public class AdminController : Controller
    {

        private readonly rsDbContext db;

        public AdminController(rsDbContext db)
        {
            this.db = db;
        }

        //session working..
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
        public IActionResult register(RegAdmin reg)
        {
            db.AdminReg.Add(reg);
            db.SaveChanges();
            return RedirectToAction("login");
        }

        public IActionResult login()
        {
            if (HttpContext.Session.GetString("s") != null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult login(RegAdmin log)
        {
            var login = db.AdminReg.Where(db => db.Email == log.Email && db.Password == log.Password).FirstOrDefault();
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
