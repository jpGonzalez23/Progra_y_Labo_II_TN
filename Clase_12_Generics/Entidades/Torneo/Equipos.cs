using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Torneo
{
    public abstract class Equipos
    {
        protected string nombre;
        protected DateTime fecha;

        /// <summary>
        /// Propiedad get y set del atributo nombre
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Propiedad get y set del atriburo fecha
        /// </summary>
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        /// <summary>
        /// Constructor de instancia para la clase Equipos
        /// </summary>
        /// <param name="nombre">Parametro de nombre</param>
        /// <param name="fecha">Parametro de fecha de creacion</param>
        public Equipos(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fecha = fecha;
        }

        /// <summary>
        /// Sobrecarga del operador == para saber si dos equipos son iguales
        /// </summary>
        /// <param name="a">Parametro a comparar</param>
        /// <param name="b">Parametro a comparar</param>
        /// <returns>Retorna true si tiene el mismo nombre y fecha de creacion</returns>
        public static bool operator ==(Equipos a, Equipos b)
        {
            return a.nombre == b.nombre && a.fecha == b.fecha;
        }

        /// <summary>
        /// Sobrecarga del metodo != para saber si dos equipo son distintos
        /// </summary>
        /// <param name="a">Parametro a comparar</param>
        /// <param name="b">Parametro a comparar</param>
        /// <returns>Retorna treu si son distitos</returns>
        public static bool operator !=(Equipos a, Equipos b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Metodo para retornar la informacion del nombre y fecha de cracion del equipo
        /// </summary>
        /// <returns>Retorna una cadena de caracteres</returns>
        public string Ficha()
        {
            return $"{nombre} fundado el {fecha.ToString("dd/MM/yyyy")}";
        }
    }
}
