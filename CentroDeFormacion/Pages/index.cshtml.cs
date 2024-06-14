using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using CentroDeFormacion.Model;

namespace CentroDeFormacion.Pages
{
    public class IndexModel : PageModel
    {
        public List<Curso> Cursos { get; set; }

        public void OnGet()
        {
            Cursos = new List<Curso>
            {
                new Curso { codigo_curso = 1, nombre_curso = "Curso 1", valor_curso = 1000 },
                new Curso { codigo_curso = 2, nombre_curso = "Curso 2", valor_curso = 2000 }
            };
        }
    }
}

