using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Mascota
{

    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Tipo { get; set; }

    public Mascota(string nombre, int edad, string tipo)
    {
        this.Nombre = nombre;
        this.Edad = edad;
        this.Tipo = tipo;
    }

    public void HacerRuido()
    {
       
    }
}

class Program
{

    static void Main(string[] args)
    {

        Mascota perro = new Mascota("clifor", 5, "Perro");
        Mascota gato = new Mascota("tigresa", 3, "Gato");
        Mascota conejo = new Mascota("seus", 2, "Conejo");

        Console.WriteLine(" Mascotas ");
        Console.WriteLine(
            "{0} | {1} | {2}",
            perro.Nombre,
            perro.Edad,
            perro.Tipo
        );
        Console.WriteLine(
            "{0} | {1} | {2}",
            gato.Nombre,
            gato.Edad,
            gato.Tipo
        );
        Console.WriteLine(
            "{0} | {1} | {2}",
            conejo.Nombre,
            conejo.Edad,
            conejo.Tipo
        );

        perro.HacerRuido();
        gato.HacerRuido();
        conejo.HacerRuido();

        while (true)
        {
            perro.HacerRuido();
            gato.HacerRuido();
            conejo.HacerRuido();

            System.Threading.Thread.Sleep(1000);
        }
    }
}
