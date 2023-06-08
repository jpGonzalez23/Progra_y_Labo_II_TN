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
        private string apellido;
        private int id;

        public Persona() { }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(int id, string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.id = id;
        }

        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Apellido { get => this.apellido; set => this.apellido = value; }
        public int Id { get => this.id; set => this.id = value; }
    }
}
