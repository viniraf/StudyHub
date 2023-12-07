using Microsoft.AspNetCore.Mvc;
using StudyHub.Models;

namespace StudyHub.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid == false)
                {
                    return View("Index");
                }

                if (loginModel.Username == "admin" &&  loginModel.Password == "123")
                {
                    return RedirectToAction("Index", "Home");
                }

                TempData["ErrorMessage"] = $"Invalid username and/or password, please try again";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = $"Unable to login, please try again";
                return RedirectToAction("Index");
            }
        }

    }
}
