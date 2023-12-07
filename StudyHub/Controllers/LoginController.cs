using Microsoft.AspNetCore.Mvc;

namespace StudyHub.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
