using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Realice una aplicacion que permita introducir el nombre y
 * salario de 3 trabajadores y muestre el promedio de estos.
 */
namespace Program_04_SueldoTrabajadores
{
    class Program
    {
        static void Main(string[] args)
        {
            string Trabajador1, Trabajador2, Trabajador3;
            double Sueldo1, Sueldo2, Sueldo3, Promedio;

            Console.Write("Introduce el Nombre del Primer Trabajador: ");
            Trabajador1 = Console.ReadLine();
            Console.Write("Introduce el sueldo de " + Trabajador1 + ": ");
            Sueldo1 = double.Parse(Console.ReadLine());

            Console.Write("Introduce el Nombre del Segundo Trabajador: ");
            Trabajador2 = Console.ReadLine();
            Console.Write("Introduce el sueldo de " + Trabajador2 + ": ");
            Sueldo2 = double.Parse(Console.ReadLine());

            Console.Write("Introduce el Nombre del Tercer Trabajador: ");
            Trabajador3 = Console.ReadLine();
            Console.Write("Introduce el sueldo de " + Trabajador3 + ": ");
            Sueldo3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Los trabajadores son: {0}, {1} y {2}.", Trabajador1, Trabajador2, Trabajador3);
            Promedio = (Sueldo1 + Sueldo2 + Sueldo3) / 3;
            Console.WriteLine("El promedio del salario de los trabajadores es: " + Promedio);
            Console.ReadKey();

        }
    }
}