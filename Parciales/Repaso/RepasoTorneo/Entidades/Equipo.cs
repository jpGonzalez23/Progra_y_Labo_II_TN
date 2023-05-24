using System.Text;

namespace Entidades
{
    public abstract class Equipo
    {
        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosGanados;
        protected int partidosPerdios;
        protected int partidosJugados;
        protected int puntuacion;

        protected Equipo(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Tipo
        {
            get { return ""; }
        }

        public int PartidosEmpatados
        {
            get { return this.partidosEmpatados; }
            set
            {
                if (value > 0)
                {
                    this.partidosEmpatados = value;
                }
            }
        }

        public int PartidosGanado
        {
            get { return this.partidosGanados; }
            set
            {
                if (value > 0)
                {
                    this.partidosGanados = value;
                }
            }
        }

        public int PartidosPerdidos
        {
            get { return this.partidosPerdios; }
            set
            {
                if (value > 0)
                {
                    this.partidosPerdios = value;
                }
            }
        }

        public int PartidosJugados
        {
            get { return this.partidosJugados; }
            set
            {
                if (value > 0)
                {
                    this.partidosJugados = value;
                }
            }
        }
        public int Puntuacion
        {
            get { return this.puntuacion; }
            set
            {
                if (value > 0)
                {
                    this.puntuacion = value;
                }
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Equipo && obj.GetType() == this.GetType();
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.nombre == e2.nombre &&  e1.GetType() == e2.GetType();
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre del equipo: {this.Nombre}");

            return sb.ToString();
        }

        public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
        {
            if (equipoA.Equals(equipoB))
            {
                int dificultadEquipoA = equipoA.GetDificultad();
                int dificultadEquipoB = equipoB.GetDificultad();

                equipoA.PartidosJugados++;
                equipoB.PartidosJugados++;

                if (dificultadEquipoA > dificultadEquipoB)
                {
                    equipoA.PartidosGanado += 3;
                    
                    return true;
                }
                else if (dificultadEquipoA < dificultadEquipoB)
                {
                    equipoB.PartidosGanado += 3;
                    return true;
                }
                else
                {
                    equipoA.PartidosEmpatados += 1;
                    equipoB.PartidosEmpatados += 1;
                    return true;
                }
            }
            return false;
        }

        public abstract int GetDificultad();
    }
}