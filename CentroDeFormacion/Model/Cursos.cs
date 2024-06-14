namespace CentroDeFormacion.Model
{
    public class Curso
    {
        public int codigo_curso { get; set; }
        public string nombre_curso { get; set; }
        public decimal valor_curso { get; set; }

    }
    public class Cursos
    {
        List<Curso> cursos = new List<Curso>();

        public void insertar_curso(Curso curso)
        {
            cursos.Add(curso);

        }

        public Curso buscar_curso(int codigoCurso)
        {
            foreach (Curso curso in cursos)
            {
                if (curso.codigo_curso == codigoCurso)
                {
                    return curso;
                }
            }
            return null;
        }
        public void actualizar_valor_curso(int codigoCurso, decimal nuevo_valor_curso)
        {
            var curso = buscar_curso(codigoCurso);
            if (curso != null)
            {
                curso.valor_curso = nuevo_valor_curso;
            }

        }
    }
}
