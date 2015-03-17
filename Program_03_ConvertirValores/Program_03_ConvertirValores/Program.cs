using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_03_ConvertirValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un numero de estudiantes: ");
            int Estudiantes = int.Parse(Console.ReadLine());
            Console.WriteLine("La cantidad de estudiantes es: " + Estudiantes);

            Console.Write("Introduce alguna estatura: ");
            float Estatura = float.Parse(Console.ReadLine());
            Console.WriteLine("La estatura introducida es : " + Estatura);

            Console.WriteLine("Estudiantes: {0}, Estatura: {1}", Estudiantes, Estatura);

            Console.ReadKey();

        }
    }
}
