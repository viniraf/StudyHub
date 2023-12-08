using Microsoft.AspNetCore.Mvc;

namespace StudyHub.Controllers
{
    public class StudyGroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateStudyGroup()
        {

            return View();
        }
    }
}
