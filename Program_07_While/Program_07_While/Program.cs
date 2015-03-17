using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_07_While
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = " ";

            while (pass != "strikeforce") {
                Console.Write("Introduce la contraseña: ");
                pass = Console.ReadLine();
                if(pass != "strikeforce"){
                    Console.WriteLine("La contraseña es incorrecta intente de nuevo.");
                }
            }

            Console.WriteLine("La Contraseña es correcta ¡¡¡");
            Console.WriteLine("Presione una tecla para salir.");
            Console.ReadKey();
        }
    }
}
