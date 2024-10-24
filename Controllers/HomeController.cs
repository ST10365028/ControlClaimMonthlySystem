using Microsoft.AspNetCore.Mvc;
using ControlClaimMonthlySystem.Models;

namespace ControlClaimMonthlySystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Simulate successful login
                ViewBag.Message = "Login Successful";
                return RedirectToAction("Index", "Claim");
            }
            return View();
        }
    }
}

