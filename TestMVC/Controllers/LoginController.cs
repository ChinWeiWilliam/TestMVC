using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System;
using System.Security.Cryptography.Xml;
using TestMVC.MvcEduModels;
using TestMVC.Session;
using BCrypt.Net;

namespace TestMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly MvcEduContext _context;
        public LoginController(MvcEduContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Account, string Password)
        {
            bool result = true;
            var user = _context.Members.SingleOrDefault(u => u.Account == Account);
            
            if(user != null)
            {
                if(user.Account == Account) {
                    bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(Password,user.Password);//進行比對雜湊後的密碼
                    if(isPasswordCorrect)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                else
                {
                    result = false;
                }

            }
            else
            {
                result = false;
            }
            if(result)
            {
                HttpContext.Session.SetString("account", user.UserName);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                result = false;
                ViewBag.ErrorMessage = "登入失敗，請檢查您的帳號和密碼。";

                return View();
            }
        }
        [Route("register.aspx")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(Member member,IFormFile Photo)
        {
            Models.Signup sign = new Models.Signup(_context);
            
            bool succes =  sign.Register(member,Photo);

            if (succes)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ViewBag.ErrorMessage = "註冊失敗，帳號重複。";
                return RedirectToAction("Register", "Login");
            }
        }
    }
}
