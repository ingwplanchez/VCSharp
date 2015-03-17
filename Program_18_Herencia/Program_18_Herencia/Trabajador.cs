using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_18_Herencia
{
    public class Trabajador:Persona
    {
        private int CantidadAnnos;
        private float Salario;
        private string area;

        public string Area
        {
            get { return area; }
            set { area = value; }
        }

        public float Salario1 
        {
            get { return Salario; }
            set { Salario = value; }
        }

        public int CantidadAnnos1
        {
            get { return CantidadAnnos; }
            set { CantidadAnnos = value; }
        }

        public Trabajador(string nombre, int edad, float peso, int CantidadAnnos,float Salario, string area):base(nombre,edad,peso){

            this.CantidadAnnos = CantidadAnnos;
            this.Salario = Salario;
            this.area = area;
        }
    }
}
