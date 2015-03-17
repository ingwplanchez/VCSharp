using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_16_Sobrecarga
{
    class Persona
    {
        public string nombre; // Podemos acceder desde cualquier parte del programa
        public int edad; // Podemos acceder solo desde esta clase
        public float peso; // Podemos acceder desde las clases que hereden de esta clase
        

        // Metodo Constructor
        public Persona(string nombre, int edad, float peso)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
        }

        int[] notas = new int[] { 10, 9, 10, 8 }; // Podemos acceder solo en este bloque
        // Definicion de un metodo
        public float PromedioNotas()
        {
            float suma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                suma = suma + notas[i];
            }
            float promedio = suma / notas.Length;
            return promedio;
        }

        // Definicion de metodos Sobrecargados

        public bool BuenRendimiento(float ValorIntroducido)
        {
            double promedio = PromedioNotas();

            if (promedio >= ValorIntroducido)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool BuenRendimiento()
        {

            float promedio = PromedioNotas();
            if (promedio >= 4.5)
            {
                return true;
            }

            else
            {
                return false;
            }
    }
}
