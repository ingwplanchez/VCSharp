using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_08_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = " " ; 

            do{
                Console.Write("Introduce una contraseña: ");
                pass = Console.ReadLine();
            }while(pass != "strikeforce");

            Console.WriteLine("La Contraseña es correcta ¡¡¡");
            Console.WriteLine("Presione una tecla para salir.");
            Console.ReadKey();

        }
    }
}
