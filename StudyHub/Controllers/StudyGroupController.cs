using Microsoft.AspNetCore.Mvc;
using StudyHub.Data;
using StudyHub.Models;

namespace StudyHub.Controllers
{
    public class StudyGroupController : Controller
    {

        private readonly StudyHubDbContext _context;

        public StudyGroupController(StudyHubDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            // Obter a lista de grupos do banco de dados
            List<StudyGroupModel> groups = _context.StudyGroup.ToList();

            // Atribuir a lista de grupos à propriedade Groups da ViewBag
            ViewBag.Groups = groups;

            return View();
        }

        public IActionResult CreateStudyGroup()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateStudyGroup(StudyGroupModel model)
        {
            if (ModelState.IsValid)
            {
                // Definindo manualmente alguns valores
                model.CreateUserId = 1;
                model.CreateDate = DateTime.Now;
                model.UpdateDate = DateTime.Now;

                // Adicionando o novo grupo ao contexto e salvando no banco de dados
                _context.StudyGroup.Add(model);
                _context.SaveChanges();

                // Redirecionando para a página principal
                return RedirectToAction("Index");
            }

            // Se o modelo não for válido, retorna para a página de criação
            return RedirectToAction("Index");
        }
    }
}
