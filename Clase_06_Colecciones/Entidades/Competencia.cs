using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine("----- Competencia -----");
            mensaje.AppendLine("Competidores: " + this.cantidadCompetidores);

            foreach (AutoF1 auto in this.competidores)
            {
                mensaje.AppendLine("--------");
                mensaje.AppendLine(auto.Mostrar());
                mensaje.AppendLine("--------");
            }

            return mensaje.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if (c.competidores.Count < c.cantidadCompetidores && c != a)
            {
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                Random rdn = new Random();
                a.CantidadCombustible = (short)rdn.Next(15, 100);
                return true;
            }
            return false;
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 auto in c.competidores)
            {
                if (auto == a)
                {
                    return true;
                }
            }
            return false;

        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 auto in c.competidores)
            {
                if (auto == a)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
