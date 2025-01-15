using System.Collections.Generic;

namespace EscuelaApp
{
    public class Clase
    {
        public string Identificador { get; set; }
        public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
        public List<Profesor> Profesores { get; set; } = new List<Profesor>();
        public Escuela Escuela { get; set; }

        public Clase(string identificador)
        {
            Identificador = identificador;
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public void AgregarProfesor(Profesor profesor)
        {
            Profesores.Add(profesor);
        }
    }
}
