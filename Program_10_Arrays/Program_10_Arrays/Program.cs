using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_10_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] VectorUnidimensional = new int[]{0,1,2,3};
            // int[] VectorUnidimensional = new int[100];

            int[,] VectorBidimensional = new int[3,3];
            //int[,] VectorBidimensional = new int[3,3]{{1,2,3},{4,5,6},{7,8,9}}      

            //int[] numeros = new int[] { 1, 2, 3, 4 };
            int[] numeros = { 1, 2, 3, 4 };
            int[] numeros2 = { 5, 6, 7, 8 };
            int[] numeros3 = { 69, 2, 45, 4 };
            
            // Saber la cantidad de elementos de un array.
            Console.WriteLine(numeros.Length);

            // Copia un array en otro.
            numeros.CopyTo(numeros2,0);

            // Ordena de menor a mayor.
            Array.Sort(numeros3);

            // Invierte el oden del array.
            Array.Reverse(numeros);


        }
    }
}
