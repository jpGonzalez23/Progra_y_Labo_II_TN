using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private int totalGoles;
        private int partidosJugados;
        private float promedioGoles;
        private string nombre;

        private Jugador()
        {
            this.promedioGoles = 0;
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        private Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni,nombre)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }

        public float GetPromedioGoles()
        {
            return (float)this.totalGoles / this.partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"Nombre: {this.nombre}");
            mensaje.AppendLine($"DNI: {this.dni}");
            mensaje.AppendLine($"Partidos jugados: {this.partidosJugados}");
            mensaje.AppendLine($"Total de goles: {this.totalGoles}");
            mensaje.AppendLine($"Promedio de goles: {this.promedioGoles}");

            return mensaje.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}
