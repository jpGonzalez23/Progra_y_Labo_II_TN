using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ingresante
    {
        private string[] curso;
        private string direccion;
        private string genero;
        private string nombre;
        private string pais;
        private int edad;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] curso, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.curso = curso;
            this.edad = edad;
        }

        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.Append($"Nombre del alumno: {this.nombre}");
            mensaje.Append($"Genero: {this.genero}");
            mensaje.Append($"Edad: {this.edad}");
            mensaje.Append($"Dirección: {this.direccion}");
            mensaje.Append($"País: {this.pais}");
            mensaje.Append($"Curos: {this.curso}");

            return mensaje.ToString();
        }
    }
}
