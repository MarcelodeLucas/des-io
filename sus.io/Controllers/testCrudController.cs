using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sus.io.Data;
using sus.io.Models;

namespace sus.io.Controllers
{
    public class testCrudController : Controller
    {

        private readonly MeuDBcontext _contexto;

        public testCrudController(MeuDBcontext contexto)
        {
            _contexto = contexto;
        }


        public IActionResult Index()
        {
            var aluno = new aluno
            {
                Nome = "celo",
                dataNascimento = DateTime.Now,
                Email = "marcelolucas787@gmail.com"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            var aluno2 = _contexto.Alunos.Find(aluno.id);
            var aluno3 = _contexto.Alunos.FirstOrDefault(a=>a.Email == "marcelolucas787@gmail.com");
            var aluno4 = _contexto.Alunos.Where(a => a.Nome == "celo");



            aluno.Nome = "joão";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();

            return View();
        }
    }
}
