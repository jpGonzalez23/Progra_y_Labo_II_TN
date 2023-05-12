using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ModuleEquipoDeFutbol
{
    public class Persona
    {
        private long dni;
        private string nombre;

        /// <summary>
        /// Propiedad del atributo de DNI
        /// </summary>
        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (value < 8)
                {
                    this.dni = value;
                }
            }
        }

        /// <summary>
        /// Propiedad del atributo de Nombre
        /// </summary>
        public string Nombre 
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        /// <summary>
        /// Constructor para el ingreso de nombre 
        /// </summary>
        /// <param name="nombre">Ingreso del nombre</param>
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Sobrecarga del constructor, Contrctor para el ingreso de nombre y dni
        /// </summary>
        /// <param name="nombre">Parametro para el ingreso del nombre</param>
        /// <param name="dni">Parametro para el ingreso del dni</param>
        public Persona(string nombre, long dni) : this(nombre)
        {
            this.dni = dni;
        }

        /// <summary>
        /// Metodo para Mostrar datos de persona
        /// </summary>
        /// <returns>Retorno una cadena de texto con los datos</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Dni: {this.Dni}");

            return sb.ToString();
        }
    }
}
