using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_14_Clases
{
    /* Modificadores de accesabilidad Para Atributos clases y metodos:
     * 
     * public : Permite acceder desde cualquier parte del programa.
     * private : Permite acceder solo desde esta clase.
     * protected: Podemos acceder solo en este bloque.
     * 
     */

    public class Clase
    {
        public string nombre = "Wilmer"; // Podemos acceder desde cualquier parte del programa
        public int edad; // Podemos acceder solo desde esta clase
        public float peso ; // Podemos acceder desde las clases que hereden de esta clase

        int[] notas = new int[] {10,9,10,8}; // Podemos acceder solo en este bloque


        Clase2 GuardarCurso; // Se comporta como private si no se especifica nada

        public double PromedioNotas() { 
            double suma = 0;
            for (int i = 0; i < notas.Length; i++) {
                suma = suma + notas[i];
            }
            double promedio = suma / notas.Length;
            return promedio;
        }

        public void LimpiarNotas() {
            Array.Clear(notas, 0, notas.Length);
        }

        public bool BuenRendimiento(float ValorIntroducido)
        {
            double promedio = PromedioNotas();
           
            if (promedio >= ValorIntroducido)
            {
                return true;
            }

            else {
                return false;
            }
        }

    }
}
 