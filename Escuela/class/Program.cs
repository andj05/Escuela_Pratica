using System;

namespace EscuelaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Bienvenido al Sistema de Gestión Escolar ===\n");

            // Crear la escuela (Aquí es donde comienza todo)
            var escuela = new Escuela("Escuela Las Yayas");

            // Crear las clases (Por ejemplo, 4to de básica, 5to de primaria, etc.)
            var clase1 = new Clase("4B");
            var clase2 = new Clase("5A");

            // Agregar estudiantes (Nombre y su matrícula única)
            var estudiante1 = new Estudiante("Anddy Jara", "20240148");
            var estudiante2 = new Estudiante("Sandra Ramírez", "20240199");

            // Crear los profesores (Aquí van los maestros de las clases)
            var profesor1 = new Profesor("Samuel Lorenzo");
            var profesor2 = new Profesor("Ramona Ledesma");

            // Crear los cursos o materias (Por ejemplo, Matemáticas y Lengua Española)
            var curso1 = new Curso("Matemáticas", 20, 50); // 20 clases, 50 ejercicios
            var curso2 = new Curso("Lengua Española", 15, 40); // 15 clases, 40 ejercicios

            // Asignar las materias a los profesores (Cada profe enseña sus cursos)
            profesor1.AgregarCurso(curso2); // Samuel enseña Lengua Española
            profesor2.AgregarCurso(curso1); // Ramona enseña Matemáticas

            // Asignar estudiantes y profesores a las clases
            // En esta parte decimos quién va para cuál clase
            clase1.AgregarEstudiante(estudiante1); // Anddy está en 4B
            clase1.AgregarProfesor(profesor1);    // Samuel enseña en 4B

            clase2.AgregarEstudiante(estudiante2); // Sandra está en 5A
            clase2.AgregarProfesor(profesor2);    // Ramona enseña en 5A

            // Agregar las clases a la escuela (Se arman las aulas con todo el personal)
            escuela.AgregarClase(clase1);
            escuela.AgregarClase(clase2);

            // Mostrar la información de la escuela (Resumen de todo)
            Console.WriteLine($"Escuela: {escuela.Nombre}");
            Console.WriteLine(new string('-', 40)); // Línea divisoria para mejor presentación

            foreach (var clase in escuela.Clases)
            {
                Console.WriteLine($"\nClase: {clase.Identificador}");
                Console.WriteLine($"Número de Estudiantes: {clase.Estudiantes.Count}");
                Console.WriteLine($"Número de Profesores: {clase.Profesores.Count}\n");

                Console.WriteLine("Estudiantes:");
                foreach (var estudiante in clase.Estudiantes)
                {
                    Console.WriteLine($"  - {estudiante.Nombre} (Matrícula: {estudiante.NumeroUnico})");
                }

                Console.WriteLine("\nProfesores:");
                foreach (var profesor in clase.Profesores)
                {
                    Console.WriteLine($"  - {profesor.Nombre}");
                    Console.WriteLine("    Cursos:");
                    foreach (var curso in profesor.Cursos)
                    {
                        Console.WriteLine($"      * {curso.Nombre} (Clases: {curso.RecuentoClases}, Ejercicios: {curso.RecuentoEjercicios})");
                    }
                }
            }

            Console.WriteLine("\n=== Fin del Sistema de Gestión Escolar ===");
        }
    }
}
