using Microsoft.AspNetCore.Mvc;

namespace StudyHub.Controllers
{
    public class StudyGroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
