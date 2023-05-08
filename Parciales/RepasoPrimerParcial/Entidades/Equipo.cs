using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo 
    {
        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdidos;
        protected int puntuacion;

        protected Equipo(string nombre) 
        {
            this.nombre = nombre;
        }

        public string Nombre 
        { 
            get 
            { 
                return this.nombre; 
            } 
        }

        public string Tipo 
        { 
            get 
            { 
                return this.GetType().Name; 
            } 
        }

        public int PJ
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }

        public int PE
        {
            get
            {
                return this.partidosEmpatados;
            }
            set
            {
                this.partidosEmpatados = value;
            }
        }

        public int PP
        {
            get
            {
                return this.partidosPerdidos;
            }
            set
            {
                this.partidosPerdidos = value;
            }
        }

        public int PG
        {
            get
            {
                return this.partidosGanados;
            }
            set
            {
                this.partidosGanados = value;
            }
        }

        public int Puntuacion
        {
            get
            {
                return this.puntuacion;
            }
            set
            {
                this.puntuacion = value;
            }
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");

            return sb.ToString();
        }

        public abstract int GetDificultad();

        public static bool JugarPartido(Equipo equipo1, Equipo equipo2)
        {
            if (equipo1.Tipo != equipo2.Tipo)
            {
                return false;
            }

            equipo1.partidosJugados++;
            equipo2.partidosJugados++;

            int dificultadEquipo1 = equipo1.GetDificultad();
            int dificultadEquipo2 = equipo2.GetDificultad();

            if (dificultadEquipo1 > dificultadEquipo2)
            {
                equipo1.puntuacion += 3;
                equipo1.partidosGanados++;
                equipo2.partidosPerdidos++;
            }
            else if (dificultadEquipo1 < dificultadEquipo2)
            {
                equipo2.puntuacion += 3;
                equipo2.partidosGanados++;
                equipo1.partidosPerdidos++;
            }
            else
            {
                equipo1.puntuacion++;
                equipo2.puntuacion++;
                equipo1.partidosEmpatados++;
                equipo2.partidosEmpatados++;
            }

            return true;
        }


        public static bool operator ==(Equipo a, Equipo b)
        {
            return a.Equals(b) && a.Nombre == b.Nombre;
        }

        public static bool operator !=(Equipo a, Equipo b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Equipo other = (Equipo)obj;
            return Tipo.Equals(other.Tipo);
        }

    }
}
