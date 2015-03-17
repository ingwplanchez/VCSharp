using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_18_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Trabajador obj = new Trabajador("Wilmer", 24, 70, 5, 500, "Ingenieria");
            Console.WriteLine("La Cantidad de años es: " + obj.CantidadAnnos1);
            Console.ReadKey();
        }
    }
}
