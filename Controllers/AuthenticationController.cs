using ShaluAcxiom.Data;
using ShaluAcxiom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ShaluAcxiom.Controllers
{
    public class AuthenticationController:Controller
    {
        private readonly AppDbContext _context;
        public AuthenticationController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Register()
        { 
            return View();  
        }
        [HttpPost]
        public IActionResult Register(UserRegister user)

        {
            _context.userRegisters.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserLogin login)
        {
            var user = _context.userRegisters.FirstOrDefault(x => x.Email == login.Email && x.Password == login.Password);
            if (user == null)
            {
                ViewBag.Error = "Invalid Email or Password!";
                return View(login);
            }
            else
            {
                //TempData["UserName"] = user.UserName;
                //TempData["Email"] = user.Email;

                HttpContext.Session.SetString("UserName", user.UserName);
                HttpContext.Session.SetString("Email", user.Email);
                return RedirectToAction("UserDashboard", "Dashboard");
            }
            

            // Login successful → Dashboard  
            //return RedirectToAction("Index", "Dashboard");
        }
        //public IActionResult Dashboard()
        //{
        //    if (HttpContext.Session.GetString("UserName") == null)
        //    {
        //        return RedirectToAction("Login");
        //    }
        //    //ViewBag.username=TempData["UserName"];
        //    //ViewBag.useremail = TempData["Email"];

        //    return View();
        //}
        //public IActionResult Logout()
        //{
        //    HttpContext.Session.Clear();
        //    return RedirectToAction("Login", "Authentication");
        //}


    }
}
