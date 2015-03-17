using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_16_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona Objeto = new Persona("wilmer", 24, 60);
            float promedio = Objeto.PromedioNotas();
            Console.WriteLine("El promedio de la persona es: "+promedio);
            bool resultado = Objeto.BuenRendimiento();
        }      
    }
}
