using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ModuleEquipoDeFutbol
{
    public class Equipo
    {
        private short cantDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        /// <summary>
        /// Constructor privado
        /// </summary>
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        /// <summary>
        /// Sobrecarga del constructor, Constructor para el ingreso de la cant de jugadores, y el nombre
        /// </summary>
        /// <param name="cantDeJugadores">ingreso de cant de jugadores</param>
        /// <param name="nombre">ingreso del nombre</param>
        public Equipo(short cantDeJugadores, string nombre) : this()
        {
            this.cantDeJugadores = cantDeJugadores;
            this.nombre = nombre;
        }

        /// <summary>
        /// Metodo para agregar un jugador al equipo
        /// </summary>
        /// <param name="e">Equipo</param>
        /// <param name="j">jugador</param>
        /// <returns>Retorna true si se agrego, false si ya esta agregado</returns>
        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count < e.cantDeJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                    if (item == j)
                    {
                        return false;
                    }
                }
            }

            e.jugadores.Add(j);
            return true;
        }
    }
}
