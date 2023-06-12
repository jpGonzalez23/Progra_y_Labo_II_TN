using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apelldio;
        private int edad;

        public Persona(string nombre, string apelldio, int edad)
        {
            this.nombre = nombre;
            this.apelldio = apelldio;
            this.edad = edad;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apelldio
        {
            get { return this.apelldio; }
            set { this.apelldio = value; }
        }

        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }


    }
}
