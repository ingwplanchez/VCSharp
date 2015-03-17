using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_13_Enumeradores
{
    enum Dias {Domingo,Lunes,Martes,Miercoles,Jueves,Viernes,Sabado}

    class Program
    {
        static void Main(string[] args)
        {
            int x = (int)Dias.Domingo;
            Console.WriteLine(Dias.Domingo);
            Console.WriteLine(x);

            foreach (string n in Enum.GetNames(typeof(Dias)))
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Presiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
