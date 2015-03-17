using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_15_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Introduce una edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Introduce un peso: ");
            float peso = float.Parse(Console.ReadLine());

            Persona objeto = new Persona(nombre,edad,peso);

            Console.Write("Nombre: ");
            Console.WriteLine(objeto.nombre);

            Console.Write("Edad: ");
            Console.WriteLine(objeto.edad);

            Console.Write("Peso: ");
            Console.WriteLine(objeto.peso);

            Console.Write("Presiona una tecla para salir . . . ");
            Console.ReadKey();
        }
    }
}
