using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_06_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cual es tu lenguaje de programacion Favorito?: ");
            string lenguaje = Console.ReadLine();

            switch(lenguaje)
            {
                case "java":
                    Console.WriteLine("Tu lenguaje Favorito es el mas usado en la actualidad¡¡¡");
                    break;
                   
                case "python":
                    Console.WriteLine("Tu lenguaje Favorito es el mas facil de aprender¡¡¡");
                    Console.WriteLine("Python Buena eleccion.");
                    break;
                    
                case "c#":
                    Console.WriteLine("Tu lenguaje Favorito se uso para hacer esta aplicacion¡¡¡");
                    break;

                default:
                    Console.WriteLine("Caso que se ejecuta por defecto");
                    break;
            }

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
