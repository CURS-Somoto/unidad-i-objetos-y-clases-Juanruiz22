using System;

namespace ClaseLibro
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine("Título: {0}", Titulo);
            Console.WriteLine("Autor: {0}", Autor);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Libro libro1 = new Libro();
            libro1.Titulo = "El Señor de los Anillos";
            libro1.Autor = "J.R.R. Tolkien";

            Libro libro2 = new Libro();
            libro2.Titulo = "Cien años de soledad";
            libro2.Autor = "Gabriel García Márquez";

            libro1.MostrarInformacion();
            libro2.MostrarInformacion();
            Console.ReadKey();
        }
    }
}
