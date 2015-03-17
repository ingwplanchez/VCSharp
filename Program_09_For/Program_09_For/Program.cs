using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_09_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Introduce tu nombre: ");
                string nombre = Console.ReadLine();

            Console.Write("Introduce el numero de veces que quieres que se imprima tu nombre: ");
            int numero = int.Parse(Console.ReadLine());

            for (i = 1; i <= numero; i++) {

                //Console.WriteLine(nombre);
                Console.WriteLine("{0}.- {1}.",i,nombre);
            }

            Console.WriteLine("Presiona una tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
