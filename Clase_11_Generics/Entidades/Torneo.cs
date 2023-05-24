using System.Text;

namespace Entidades
{
    public class Torneo<T> where T : Equipos
    {
        protected List<T> equipos;
        protected string nombre;
        
        /// <summary>
        /// Constructor de instacia de torneo
        /// </summary>
        /// <param name="nombre">Parametro a ingresar</param>
        public Torneo(string nombre) 
        {
            this.nombre = nombre;
            this.equipos = new List<T>();
        }

        /// <summary>
        /// Sobrecarga del operador == para compara si un equipo esta dentro de torneo
        /// </summary>
        /// <param name="torneo">Parametro a comparar</param>
        /// <param name="equipo">Parametro a comparar</param>
        /// <returns>Retorna true si esta dentro</returns>
        public static bool operator ==(Torneo<T> torneo, Equipos equipo) 
        {
            return torneo.equipos.Contains(equipo);
        }

        /// <summary>
        /// Sobrecarga del operado != para comparar si un equipo no esta dentro de torneo
        /// </summary>
        /// <param name="torneo">Parametro a comparar</param>
        /// <param name="equipo">Parametro a comparar</param>
        /// <returns>Retorna true si no esta dentro</returns>
        public static bool operator !=(Torneo<T> torneo, Equipos equipo)
        {
            return !(torneo == equipo);
        }

        /// <summary>
        /// Sobrecarga del metodo + para agregar un equipo al torneo
        /// </summary>
        /// <param name="torneo">Parametro a comparar</param>
        /// <param name="equipo">Parametro a comparar</param>
        /// <returns>Retorna el torneo</returns>
        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo != equipo)
            {
                torneo.equipos.Add(equipo);
            }

            return torneo;
        }

        /// <summary>
        /// Metodo privado para calcular el partido
        /// </summary>
        /// <param name="equipo">Parametro</param>
        /// <param name="equipo2">Parametro</param>
        /// <returns>Retorna una cadena de string</returns>
        private string CalcularPartido(T equipo, T equipo2)
        {
            int resultadoUno = new Random().Next(0, 5);
            int resultadoDos = new Random().Next(0, 5);

            return $"{equipo.Nombre} {resultadoUno} - {resultadoDos} {equipo2.Nombre}";
        }

        /// <summary>
        /// Metodo para jugar el partido
        /// </summary>
        /// <returns>Retorna un cadena de string que muestra los puntos del partido</returns>
        public string JugarPartido()
        {
            int equipo1Index = new Random().Next(0, this.equipos.Count);
            int equipo2Index = new Random().Next(0, this.equipos.Count);
          
            while (equipo2Index == equipo1Index)
            {
                equipo2Index = new Random().Next(0, this.equipos.Count);
            }
          
            T equipo1 = this.equipos[equipo1Index];
            T equipo2 = this.equipos[equipo2Index];
          
            return CalcularPartido(equipo1, equipo2);
        }

        /// <summary>
        /// Metodo para mostrar el nombre y la lista de los participantes del torneo
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Torneo: {this.nombre}");
            sb.AppendLine("Equipos participantes: ");
            foreach (T equipo in this.equipos)
            {
                sb.AppendLine(equipo.Ficha());
            }
            return sb.ToString();
        }
    }
}