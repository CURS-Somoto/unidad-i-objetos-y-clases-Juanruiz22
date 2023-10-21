using System;

namespace ClasePelicula
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public int AñoDeLanzamiento { get; set; }
        public int Calificacion { get; set; }

        public Pelicula()
        {
            Calificacion = 0;
        }

        public Pelicula(string titulo, int anioDeLanzamiento)
        {
            Titulo = titulo;
            AñoDeLanzamiento = anioDeLanzamiento;
            Calificacion = 0;
        }

        public void Calificar(int calificacion)
        {
            if (calificacion >= 1 && calificacion <= 5)
            {
                Calificacion = calificacion;
            }
            else
            {
                Console.WriteLine("La calificación debe ser entre 1 y 5");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula pelicula1 = new Pelicula("El Señor de los Anillos", 2001);
            pelicula1.Calificar(4);l
            Console.WriteLine("La calificación de la película es: {0}", pelicula1.Calificacion);
            Pelicula pelicula2 = new Pelicula("Cien años de soledad", 1967);
            pelicula2.Calificar(5);
            Console.WriteLine("La calificación de la película es: {0}", pelicula2.Calificacion);
            Console.ReadKey();
        }
    }
}
