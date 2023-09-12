﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestMVC.Models;
using TestMVC.Session;

//2023/09/12 20:21 update login method
namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Seccess Login";
            ViewBag.Message2 = HttpContext.Session.GetString("account");
            return View();
        }
        public IActionResult Logout()
        {
            
            HttpContext.Session.Remove("account");
            return RedirectToAction("Login", "Home");
        }
        public IActionResult Privacy()
        {

            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Portfolio()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult News()
        {
            return View();
        }
        public IActionResult TestRenderPartial()
        {
            List<TestModel> items = new List<TestModel>
            {
                new TestModel{Title = "標題1",Content = "1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1,1 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content11 Content1"},
                new TestModel{Title = "標題2",Content = "2 Content22 Content22 Content22 Content22 Content22 Content22 Content22 Content22 Content22 Content22 Content22 Content22 Content22 Content22 Content22 Content22 Content2"},
                new TestModel{Title = "標題3",Content = "3 Content33 Content33 Content33 Content33 Content33 Content33 Content33 Content33 Content33 Content33 Content33 Content33 Content33 Content33 Content33 Content33 Content3"},
                new TestModel{Title = "標題4",Content = "4 Content44 Content44 Content44 Content44 Content44 Content44 Content44 Content44 Content44 Content44 Content44 Content44 Content44 Content44 Content44 Content44 Content4"},

            };
            return View(items);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}