using System;

namespace EscuelaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Bienvenido al Sistema de Gestión Escolar ===\n");

            // Crear la escuela
            var escuela = new Escuela("Escuela Las Yayas");

            // Crear clases
            var clase1 = new Clase("4B");
            var clase2 = new Clase("5A");

            // Crear estudiantes con nombre y matrícula
            var estudiante1 = new Estudiante("Anddy Jara", "20240148");
            var estudiante2 = new Estudiante("Sandra Ramírez", "20240199");

            // Crear profesores
            var profesor1 = new Profesor("Samuel Lorenzo");
            var profesor2 = new Profesor("Ramona Ledesma");

            // Crear cursos o materias
            var curso1 = new Curso("Matemáticas", 20, 50);
            var curso2 = new Curso("Lengua Española", 15, 40);

            // Asignar cursos a profesores
            profesor1.AgregarCurso(curso2);
            profesor2.AgregarCurso(curso1);

            // Asignar estudiantes y profesores a las clases
            clase1.AgregarEstudiante(estudiante1);
            clase1.AgregarProfesor(profesor1);

            clase2.AgregarEstudiante(estudiante2);
            clase2.AgregarProfesor(profesor2);

            // Agregar las clases a la escuela
            escuela.AgregarClase(clase1);
            escuela.AgregarClase(clase2);

            // Mostrar información de la escuela
            Console.WriteLine($"Escuela: {escuela.Nombre}");
            Console.WriteLine(new string('-', 40)); // Línea divisora

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
