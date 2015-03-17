using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_18_Herencia
{
    public class Persona
    {
        protected string nombre = "Wilmer"; // Podemos acceder desde cualquier parte del programa
        protected int edad = 24; // Podemos acceder solo desde esta clase
        protected float peso = 60; // Podemos acceder desde las clases que hereden de esta clase
        protected int[] notas = new int[] { 10, 9, 10, 8 };

        public Persona(string nombre, int edad, float peso)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
        }

        // Propiedaddes

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }        
        
        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }       
 
        public int[] Notas
        {
            get { return notas; }
            set { notas = value; }
        }
    }
}
