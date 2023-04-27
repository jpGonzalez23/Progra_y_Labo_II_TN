using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Peso
    {
        // Atrivutos
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Cosntructores
        static Peso()
        {
            cotizRespectoDolar = 398;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizRespectoDolar;
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

        #region Conversiones

        public static implicit operator Peso(double cantidad)
        {
            return new Peso(cantidad);
        }

        public static explicit operator Dolar(Peso peso)
        {
            return new Dolar(peso.cantidad / cotizRespectoDolar);
        }

        public static explicit operator Euro(Peso peso)
        {
            return (Euro)peso;
        }
        #endregion

        #region Operaciones
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.cantidad == p2.cantidad;
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            Peso pesoAux = (Peso)d;
            return p.cantidad == pesoAux.cantidad;

            //return p.cantidad == ((Peso)d).cantidad;
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return p.cantidad == ((Peso)e).cantidad;
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.cantidad + ((Peso)d).cantidad);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.cantidad - ((Peso)d).cantidad);
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.cantidad + ((Peso)e).cantidad);
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.cantidad - ((Peso)e).cantidad);
        }
        #endregion
    }
}
