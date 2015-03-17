using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_15_Constructor
{
    class Persona
    {
        public string nombre = "Wilmer"; // Podemos acceder desde cualquier parte del programa
        public int edad; // Podemos acceder solo desde esta clase
        public float peso ; // Podemos acceder desde las clases que hereden de esta clase

        public Persona(string nombre, int edad, float peso) {
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
        }
    }
}
