using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ModuleEquipoDeFutbol
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        /// <summary>
        /// Propiedad set; get; del atributos partidos jugados
        /// </summary>
        public int PatidosJugados
        {
            get { return this.partidosJugados; }
            set { this.partidosJugados = value; }
        }

        /// <summary>
        /// Propiedad set; get; del atributos tota de goles
        /// </summary>
        public int TotalGoles
        {
            get { return this.totalGoles; }
            set { this.totalGoles = value; }
        }

        /// <summary>
        /// Propiedad get de promedio de goles
        /// </summary>
        public float PromedioGoles
        {
            get
            {
                return (float)this.totalGoles / this.partidosJugados;
            }
        }

        /// <summary>
        /// Constructor para ingresar el nombre y dni
        /// </summary>
        /// <param name="nombre">Parametro para el ingreso de nombre</param>
        /// <param name="dni">Parametro para el ingreso de dni</param>
        public Jugador(string nombre, long dni) : base(nombre, dni){ }

        /// <summary>
        /// Sobrecarga, Consctructor para el ingreso
        /// </summary>
        /// <param name="nombre">Ingreso de nombre</param>
        /// <param name="dni">Ingreso de dni</param>
        /// <param name="totalGoles">ingreso de total de goles</param>
        /// <param name="totalPartidos">ingreso de total de partidos</param>
        public Jugador(string nombre, long dni, int totalGoles, int totalPartidos) : this(nombre,dni)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }

        /// <summary>
        /// Metodo para mostrar datos
        /// </summary>
        /// <returns>Retorna una cadena de caracteres</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Partidos jugados: {this.PatidosJugados}");
            sb.AppendLine($"Total de Goles: {this.TotalGoles}");
            sb.AppendLine($"Promedio de goles: {this.PromedioGoles}");

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
