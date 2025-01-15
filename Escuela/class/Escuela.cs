using System.Collections.Generic;

namespace EscuelaApp
{
    public class Escuela
    {
        public string Nombre { get; set; }
        public List<Clase> Clases { get; set; } = new List<Clase>();

        public Escuela(string nombre)
        {
            Nombre = nombre;
        }

        public void AgregarClase(Clase clase)
        {
            clase.Escuela = this;
            Clases.Add(clase);
        }
    }
}
