using FurkanSahin.TaskManagement.UI.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FurkanSahin.TaskManagement.UI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        //c# 9.0+ record 
        [HttpPost]
        public IActionResult Login(LoginDto dto)
        {

            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }
    }
}
