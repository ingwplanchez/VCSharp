using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_12_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> lista = new List<string>();
            lista.Add("D");
            lista.Add("C");
            lista.Add("B");
            lista.Add("A");
            lista.Add("d");
            lista.Add("c");
            lista.Add("b");
            lista.Add("a");

            int[,] numeros = new int[3,4]{ {1,2,3,4}, {5,6,7,8 }, {9,10,11,12} };
            ;
            Console.WriteLine("Lista de elementos: ");
            foreach (string elemento in lista) {
                Console.WriteLine(elemento);
            }

            Console.WriteLine("Numeros:");
            foreach (int n in numeros) {
                Console.WriteLine(n);
            }


            Console.WriteLine("Presiona una tecla para salir. . .");
            Console.ReadKey();
        }
    }
}
