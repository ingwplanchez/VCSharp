using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_11_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,Elementos;
            List<string> lista = new List<string>();
            lista.Add("DLol1");
            lista.Add("CLol2");
            lista.Add("DLol3");
            lista.Add("ALol4");
            lista.Add("dLol1");
            lista.Add("cLol2");
            lista.Add("bLol3");
            lista.Add("aLol4");
            
            Console.WriteLine(lista[3]);
            Elementos = lista.Count;
            Console.WriteLine("Elementos de la lista : " + Elementos);
            Console.WriteLine("Presione una tecla para salir . . .");
            Console.Write("Posicion del elemento cLol2: ");
            Console.WriteLine(lista.IndexOf("cLol2"));
            Console.Write("Se encuentra el elemento 'x' en la lista?: ");
            Console.WriteLine(lista.Contains("x"));

            Console.WriteLine("Lista Desordenada: ");
            for (i = 0; i < Elementos; i++)
            {

                Console.WriteLine("{0}.- {1}", i+1, lista[i]);

            }

            Console.WriteLine("Lista Ordenada: ");
            lista.Sort(); // Ordena la lista

            for (i = 0; i < Elementos; i++)
            {
               
                Console.WriteLine("{0}.- {1}",i+1,lista[i]);

            }
            //lista.Clear(); // Se borran los elementos de las lista.
            Console.WriteLine("Presiona una tecla para salir. . .");
            Console.ReadKey();

        }
    }
}
