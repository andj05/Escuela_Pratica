using static EscuelaApp.Escuela;

namespace EscuelaApp
{
    public class Estudiante : Persona
    {
        public string NumeroUnico { get; set; }

        public Estudiante(string nombre, string numeroUnico) : base(nombre)
        {
            NumeroUnico = numeroUnico;
        }
        public override string ToString() => $"Estudiante: {Nombre}, Número Único: {NumeroUnico}";
    }
}
