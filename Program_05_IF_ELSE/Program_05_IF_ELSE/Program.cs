using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_05_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.Write("Introduce un nombre: ");
            nombre = Console.ReadLine();

            if ((nombre == "Wilmer") || (nombre == "wilmer"))
            {
                Console.WriteLine("EL nombre es correcto");
            }

            else {
                Console.WriteLine("EL nombre es incorrecto");
            }

            Console.ReadKey();
        }
    }
}
