using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ModuleVehiculoCompetencia
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        public enum TipoCompetencia { F1, MotoCross };
        private TipoCompetencia tipo;

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }
        public short CantidadCompetidores
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
        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }
        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }
        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine(("Cantidad de vueltas de la competencias: " + this.cantidadVueltas).ToString());
            returnAux.AppendLine(("Cantidad de competidores: " + this.cantidadCompetidores).ToString());
            foreach (AutoF1 auto in competidores)
            {
                returnAux.AppendLine(auto.MostrarDatos());
            }
            return returnAux.ToString();
        }
        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            Random combusRandom = new Random();
            bool returnAux = false;
            if (c.competidores.Count() < c.cantidadCompetidores && (c != v))
            {
                v.EnCompetencia = true;
                v.VueltasRestantes = c.cantidadVueltas;
                v.CantidadCombustible = (short)combusRandom.Next(15, 100);
                c.competidores.Add(v);
                returnAux = true;
            }
            return returnAux;
        }
        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            bool returnAux = false;
            if (c.competidores.Count() > 0 && (c == v))
            {
                c.competidores.Remove(v);
                returnAux = true;
            }
            return returnAux;
        }
        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            bool returnAux = true;
            if ((c.Tipo == Competencia.TipoCompetencia.F1 && v.GetType() != typeof(AutoF1)) || (c.Tipo == Competencia.TipoCompetencia.MotoCross && v.GetType() != typeof(MotoCross)))
            {
                returnAux = false;
            }
            else
            {
                foreach (VehiculoDeCarrera vehiculo in c.competidores)
                {
                    if (vehiculo == v)
                    {
                        returnAux = false;
                        break;
                    }
                }
            }
            return returnAux;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }
    }
}
