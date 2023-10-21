using System;

namespace ClaseEmpleado
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public double Salario { get; set; }

        public double CalcularSalarioAnual()
        {
            return Salario * 12;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Juan ruiz";
            empleado1.Salario = 1000;

            Empleado empleado2 = new Empleado();
            empleado2.Nombre = "María García";
            empleado2.Salario = 2000;

            Console.WriteLine("Salario anual de Juan Pérez: {0}", empleado1.CalcularSalarioAnual());
            Console.WriteLine("Salario anual de María García: {0}", empleado2.CalcularSalarioAnual());

            Console.ReadKey();
        }
    }
}
