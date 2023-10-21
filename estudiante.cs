using System;

namespace ClaseEstudiante
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Curso { get; set; }

        public Estudiante(string nombre, int edad, string curso)
        {
            Nombre = nombre;
            Edad = edad;
            Curso = curso;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Estudiante estudiante1 = new Estudiante("Juan ruiz", 20, "Ingeniería de Software");
            Estudiante estudiante2 = new Estudiante("francelys vanegas", 18, "ing diseño web");

            Console.WriteLine("Información del estudiante 1:");
            Console.WriteLine("Nombre: {0}", estudiante1.Nombre);
            Console.WriteLine("Edad: {0}", estudiante1.Edad);
            Console.WriteLine("Curso: {0}", estudiante1.Curso);

            Console.WriteLine("Información del estudiante 2:");
            Console.WriteLine("Nombre: {0}", estudiante2.Nombre);
            Console.WriteLine("Edad: {0}", estudiante2.Edad);
            Console.WriteLine("Curso: {0}", estudiante2.Curso);

            Console.ReadKey();
        }
    }
}
