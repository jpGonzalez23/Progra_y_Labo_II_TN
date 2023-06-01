using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Competencia
{
    public class Competencia <T> where T : VehiculoDeCarrera
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;
        public enum TipoCompetencia { F1, MotoCross };
        private TipoCompetencia tipo;

        private Competencia()
        {
            competidores = new List<T>();
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
        public List<T> ListadeVehiculos
        {
            get
            {
                return this.competidores;
            }
        }
        public T this[int i]
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
            foreach (T vehiculo in competidores)
            {
                returnAux.AppendLine(vehiculo.MostrarDatos());
            }
            return returnAux.ToString();
        }
        public static bool operator +(Competencia<T> c, T v)
        {
            Random combusRandom = new Random();
            bool returnAux = false;
            try
            {
                if (c.competidores.Count() < c.cantidadCompetidores && (c != v))
                {
                    v.EnCompetencia = true;
                    v.VueltasRestantes = c.cantidadVueltas;
                    v.CantCombustible = (short)combusRandom.Next(15, 100);
                    c.competidores.Add(v);
                    returnAux = true;
                }
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                throw new CompetenciaNoDisponibleException("Compentecia incorrecta", "Competencia", "\'Operador +\'", ex);
            }

            return returnAux;
        }
        public static bool operator -(Competencia<T> c, T v)
        {
            bool returnAux = false;
            if (c.competidores.Count() > 0 && (c == v))
            {
                c.competidores.Remove(v);
                returnAux = true;
            }
            return returnAux;
        }
        public static bool operator ==(Competencia<T> c, T v)
        {
            bool returnAux = false;
            if ((c.Tipo == Competencia<T>.TipoCompetencia.F1 && v.GetType() != typeof(AutoF1)) || (c.Tipo == Competencia<T>.TipoCompetencia.MotoCross && v.GetType() != typeof(MotoCross)))
            {
                throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencina", "Compentencia", "Validacion");
            }
            else
            {
                foreach (T vehiculo in c.competidores)
                {
                    if (vehiculo == v)
                    {
                        returnAux = true;
                        break;
                    }
                }
            }
            return returnAux;
        }
        public static bool operator !=(Competencia<T> c, T v)
        {
            return !(c == v);
        }
    }
}
