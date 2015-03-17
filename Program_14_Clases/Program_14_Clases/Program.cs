using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_14_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase ObjPersona = new Clase(); // Creracion de un objeto de la clase Clase
            Clase2 ObjCurso = new Clase2();  // Creaccion de un objeto de la clase CLase2
            Console.WriteLine(ObjPersona.nombre);
            
            Clase obj = new Clase(); // Creacion de un nuevo objeto
            Console.WriteLine("Introduce un valor a comparar:");
            float Valor = float.Parse(Console.ReadLine()); // Se pide un valor de referencia

            bool rendimiento = obj.BuenRendimiento(Valor);
            
            Console.Write("El promedio de notas es: "+obj.PromedioNotas());
            Console.WriteLine(" ");
            if (rendimiento)
            {
                Console.WriteLine("Buen rendimiento ¡¡¡");
            }
            else{
                Console.WriteLine("Mal rendimiento");
            }
            Console.WriteLine("Presione una tecla para salor . . .");
            Console.ReadKey();
        }
    }
}
