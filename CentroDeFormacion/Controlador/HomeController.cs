using CentroDeFormacion.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CentroDeFormacion.Controlador
{
    public class HomeController : Controller
    {
        private readonly Cursos _Cursos;
        private static List<Curso> cursos = new List<Curso>
    {
        new Curso { codigo_curso = 111, nombre_curso = "Curso 1", valor_curso = 1000 },
        new Curso { codigo_curso = 122, nombre_curso = "Curso 2", valor_curso = 2000 }
    };

        public HomeController()
        {
            _Cursos = new Cursos();
        }

        public IActionResult Index()
        {
            return View(cursos);
        }

        public IActionResult ModificarCurso()
        {

            return View();
        }


        public IActionResult ModificarCurso(int codigo)
        {
            var curso = cursos.FirstOrDefault(c => c.codigo_curso == codigo);
            return View(curso);
        }
    }

}
