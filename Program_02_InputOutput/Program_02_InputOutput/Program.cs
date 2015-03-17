using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_02_InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string carrera;
            int edad = 24;
            string nombre = "Wilmer";
            // .Writeline: Genera salto de linea
            Console.WriteLine("Bienvenido {0} su edad es {1}", nombre, edad);
            
            Console.Write("Introduce tu apellido: ");
            string apellido = Console.ReadLine(); // Funciona como Scanf() en C
            Console.WriteLine("{0} su apellido es {1}.", nombre, apellido);

            Console.Write("Que carrera estudias?: ");
            carrera = Console.ReadLine();
            Console.WriteLine("{0} {1} tu estudias {2}", nombre, apellido, carrera);

            // Si se quiere mostrar una sola variable
            // Console.WriteLine(" Su nombre es : + nombre);
                        
            Console.ReadKey();
        }
    }
}
