using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructores
        static Euro()
        {
            cotizRespectoDolar = 0.9;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizRespectoDolar;
        }
        #endregion

        #region Métodos
        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static void SetCotizacion(double paramCotizacion)
        {
            cotizRespectoDolar = paramCotizacion;
        }

        public double GetCantidad()
        {
            return cantidad;
        }
        #endregion

        #region Converción

        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }

        public static explicit operator Dolar(Euro euro)
        {
            return new Dolar(euro.cantidad / cotizRespectoDolar);
        }

        public static explicit operator Peso(Euro euro)
        {
            return (Peso)(Dolar)euro;
        }
        #endregion


        #region Operaciones
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return e.cantidad == ((Euro)p).cantidad;
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e.cantidad == ((Euro)d).cantidad;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.cantidad - ((Euro)p).cantidad);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).cantidad);
        }
        #endregion
    }
}
