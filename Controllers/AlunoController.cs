using Microsoft.AspNetCore.Mvc;
using app_mvc.Models;

namespace app_mvc.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Alunos
        public IActionResult Index()
        {
            Aluno _aluno = new Aluno();
            _aluno.CriarAluno();

            return View(_aluno.BuscarAluno());
        }
    }
}