using Microsoft.AspNetCore.Mvc;
using TestMVC.Session;

namespace TestMVC.Controllers
{
    public class LoginController : Controller
    {
        private IAccountService _accountService;
        public LoginController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Account, string Password)
        {
            var account = _accountService.Login(Account, Password);
            if (account != null)
            {
                HttpContext.Session.SetString("account", Account);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Invalid Login!";
                return View();
            }
            return View();

        }
    }
}
