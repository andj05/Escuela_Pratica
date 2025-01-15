
using EscuelaApp;

namespace EscuelaApp
{
    public class Profesor : Persona
    {
        public List<Curso> Cursos { get; set; } = new List<Curso>();

        public Profesor(string nombre) : base(nombre) { }

        public void AgregarCurso(Curso curso)
        {
            Cursos.Add(curso);
        }

    }
}

