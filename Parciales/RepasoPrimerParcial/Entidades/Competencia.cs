using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private string nombre;
        private int cantidadCompetidores;
        private List<Equipo> equipos;
        
        private Competencia()
        {
            this.cantidadCompetidores = 5;
        }

        public Competencia(string nombre, int cantidadCompetidores) : this()
        {
            this.nombre = nombre;
            this.cantidadCompetidores = cantidadCompetidores;
            this.equipos = new List<Equipo>();
        }

        public int CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public List<Equipo> Equipos
        {
            get
            {
                return this.equipos;
            }
        }

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

        public static string MostrarTorneo(Competencia competencia)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {competencia.Nombre}");
            sb.AppendLine($"Cantidad de competidores: {competencia.cantidadCompetidores}");
            sb.AppendLine("Equipos");
            foreach (var equipos in competencia.Equipos)
            {
                sb.AppendLine(equipos.ToString());
            }

            return sb.ToString();
        }

        public static implicit operator Competencia(string competencia)
        {
            return new Competencia(competencia, 5);
        }

        public static bool operator ==(Competencia competencia, Equipo equipo)
        {
            foreach (Equipo e in competencia.equipos)
            {
                if(e.Nombre == equipo.Nombre)
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia competencia, Equipo equipo)
        {
            return !(competencia == equipo);
        }

        public static Competencia operator +(Competencia competencia, Equipo equipo)
        {
            if(competencia != equipo || competencia.cantidadCompetidores < competencia.equipos.Count)
            {
                competencia.equipos.Add(equipo);
            }

            return competencia;
        }
    }
}
