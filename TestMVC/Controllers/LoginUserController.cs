using Microsoft.AspNetCore.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class LoginUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Get(LoginViewModel model)
        {            
            string name=model.Name;
            string password=model.Password;
            return View();
        }
    }
}
